using Meraki.Api.Extensions;
using System.Net;
using System.Net.Http.Headers;

namespace Meraki.Api.Test.Extensions;

/// <summary>
/// Tests for header redaction in diagnostic output.
///
/// <para>
/// <c>AuthenticatedBackingOffHttpClientHandler</c> applies a credential to every request and then
/// passes the whole <see cref="HttpRequestMessage"/> to the logger. Its <c>ToString()</c> renders
/// every header, so without redaction a usable credential is written wherever those messages end
/// up.
/// </para>
///
/// <para>
/// Which credential depends on configuration. With an access token, or when the Workflows API is in
/// use, it is an Authorization bearer header. Otherwise it is the API key in
/// <c>X-Cisco-Meraki-API-Key</c>, which is the more sensitive of the two because a Meraki API key
/// does not expire.
/// </para>
///
/// <para>
/// These are pure unit tests. They construct messages directly and require no credentials, no
/// configuration and no live organisation.
/// </para>
/// </summary>
public class HttpExtensionsTests
{
	private const string FakeApiKey = "0123456789abcdef0123456789abcdef01234567";
	private const string FakeToken = "fake-access-token-0123456789abcdef";

	/// <summary>
	/// The headline case: the API key must not survive into the message.
	/// </summary>
	[Fact]
	public void ToRedactedString_MerakiApiKeyHeader_DoesNotLeakTheKey()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.meraki.com/api/v1/organizations");
		request.Headers.Add("X-Cisco-Meraki-API-Key", FakeApiKey);

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain(FakeApiKey);
		rendered.Should().Contain($"X-Cisco-Meraki-API-Key: <redacted, length {FakeApiKey.Length}>");
	}

	/// <summary>
	/// The other credential path, used with an access token or the Workflows API.
	/// </summary>
	[Fact]
	public void ToRedactedString_BearerToken_KeepsTheSchemeAndRedactsTheCredential()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.meraki.com/api/v1/organizations");
		request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", FakeToken);

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain(FakeToken);
		rendered.Should().Contain($"Authorization: Bearer <redacted, length {FakeToken.Length}>");
	}

	/// <summary>
	/// Proves the defect being fixed: the framework rendering leaks, the replacement does not.
	/// </summary>
	[Fact]
	public void ToRedactedString_UnlikeToString_DoesNotContainTheKey()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.meraki.com/api/v1/organizations");
		request.Headers.Add("X-Cisco-Meraki-API-Key", FakeApiKey);

		request.ToString().Should().Contain(FakeApiKey, "the framework rendering is what leaked");
		request.ToRedactedString().Should().NotContain(FakeApiKey);
	}

	/// <summary>
	/// The diagnostically useful parts of the message must survive intact.
	/// </summary>
	[Fact]
	public void ToRedactedString_KeepsMethodUriAndOtherHeaders()
	{
		using var request = new HttpRequestMessage(HttpMethod.Put, "https://api.meraki.com/api/v1/networks/N_123/devices");
		request.Headers.Add("X-Cisco-Meraki-API-Key", FakeApiKey);
		request.Headers.TryAddWithoutValidation("User-Agent", "Meraki.Api");

		var rendered = request.ToRedactedString();

		rendered.Should().Contain("Method: PUT");
		rendered.Should().Contain("https://api.meraki.com/api/v1/networks/N_123/devices");
		rendered.Should().Contain("User-Agent: Meraki.Api");
		rendered.Should().NotContain(FakeApiKey);
	}

	/// <summary>
	/// Content headers are rendered too, so they must be redacted on the same terms.
	/// </summary>
	[Fact]
	public void ToRedactedString_RedactsContentHeaders()
	{
		using var request = new HttpRequestMessage(HttpMethod.Post, "https://api.meraki.com/api/v1/organizations")
		{
			Content = new StringContent("{}")
		};
		request.Content!.Headers.TryAddWithoutValidation("X-Api-Key", "s3cr3t-content-header");

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain("s3cr3t-content-header");
		rendered.Should().Contain("<redacted");
		rendered.Should().Contain("Content-Type: text/plain; charset=utf-8");
	}

	/// <summary>
	/// A header added without validation keeps whatever casing the caller used.
	/// </summary>
	/// <param name="headerName">The header name casing under test.</param>
	[Theory]
	[InlineData("x-cisco-meraki-api-key")]
	[InlineData("X-CISCO-MERAKI-API-KEY")]
	[InlineData("authorization")]
	[InlineData("AUTHORIZATION")]
	public void ToRedactedString_CredentialHeaders_AreRedactedWhateverTheCasing(string headerName)
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.meraki.com/");
		request.Headers.TryAddWithoutValidation(headerName, FakeApiKey);

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain(FakeApiKey);
		rendered.Should().Contain("<redacted");
	}

	/// <summary>
	/// The other standard credential-bearing header names are redacted too.
	/// </summary>
	/// <param name="headerName">The credential-bearing header name under test.</param>
	[Theory]
	[InlineData("Proxy-Authorization")]
	[InlineData("Cookie")]
	[InlineData("X-API-Key")]
	[InlineData("Api-Key")]
	[InlineData("X-Api-Token")]
	[InlineData("X-Auth-Token")]
	public void ToRedactedString_OtherCredentialHeaders_AreRedacted(string headerName)
	{
		const string secret = "s3cr3t-value-that-must-not-be-logged";
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.meraki.com/");
		request.Headers.TryAddWithoutValidation(headerName, secret);

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain(secret);
		rendered.Should().Contain("<redacted");
	}

	/// <summary>
	/// A vendor may prefix the standard header name rather than using it directly.
	/// </summary>
	[Fact]
	public void ToRedactedString_VendorPrefixedAuthorizationHeader_IsRedacted()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.meraki.com/");
		request.Headers.TryAddWithoutValidation("X-Vendor-Authorization", $"Bearer {FakeToken}");

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain(FakeToken);
		rendered.Should().Contain($"X-Vendor-Authorization: Bearer <redacted, length {FakeToken.Length}>");
	}

	/// <summary>
	/// The API key has no scheme prefix, so all of it goes rather than a leading fragment surviving.
	/// </summary>
	[Fact]
	public void ToRedactedString_KeyWithoutAScheme_IsRedactedEntirely()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.meraki.com/");
		request.Headers.Add("X-Cisco-Meraki-API-Key", "abcdef123456");

		var rendered = request.ToRedactedString();

		rendered.Should().Contain("X-Cisco-Meraki-API-Key: <redacted, length 12>");
	}

	/// <summary>
	/// A cookie value also contains a space, so treating the text before the first space as a scheme
	/// would preserve the very value being redacted. Only Authorization style headers keep a scheme.
	/// </summary>
	[Fact]
	public void ToRedactedString_CookieValueContainingASpace_IsRedactedWhole()
	{
		const string cookie = "session=abc123def456; HttpOnly";
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.meraki.com/");
		request.Headers.TryAddWithoutValidation("Cookie", cookie);

		var rendered = request.ToRedactedString();

		rendered.Should().Contain($"Cookie: <redacted, length {cookie.Length}>");
		rendered.Should().NotContain("session=abc");
	}

	/// <summary>
	/// Response rendering goes through the same redaction, so Set-Cookie is covered.
	/// </summary>
	[Fact]
	public void ToRedactedString_ResponseSetCookie_IsRedacted()
	{
		using var response = new HttpResponseMessage(HttpStatusCode.TooManyRequests);
		response.Headers.TryAddWithoutValidation("Set-Cookie", "session=abc123def456; HttpOnly");

		var rendered = response.ToRedactedString();

		rendered.Should().NotContain("abc123def456");
		rendered.Should().Contain("<redacted");
	}

	/// <summary>
	/// The status and Retry-After header drive the back-off, so a rate-limit investigation must not
	/// lose them.
	/// </summary>
	[Fact]
	public void ToRedactedString_ResponseKeepsStatusAndRetryAfter()
	{
		using var response = new HttpResponseMessage(HttpStatusCode.TooManyRequests);
		response.Headers.TryAddWithoutValidation("Retry-After", "2");

		var rendered = response.ToRedactedString();

		rendered.Should().Contain("StatusCode: 429");
		rendered.Should().Contain("Retry-After: 2");
	}

	/// <summary>
	/// A request carrying no credential is rendered with nothing removed.
	/// </summary>
	[Fact]
	public void ToRedactedString_NoCredentialHeaders_RedactsNothing()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.meraki.com/");
		request.Headers.TryAddWithoutValidation("User-Agent", "Meraki.Api");

		var rendered = request.ToRedactedString();

		rendered.Should().Contain("User-Agent: Meraki.Api");
		rendered.Should().NotContain("<redacted");
	}
}
