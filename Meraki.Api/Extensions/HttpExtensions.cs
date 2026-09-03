using System.Text;

namespace Meraki.Api.Extensions;

/// <summary>
/// Rendering of HTTP requests and responses for diagnostic output, with credential-bearing header
/// values redacted.
/// </summary>
/// <remarks>
/// The handler logs the whole <see cref="HttpRequestMessage"/> as a log argument. Its
/// <c>ToString()</c> renders every header, so the credential this client sets on each request was
/// written verbatim into the log. These helpers produce the same information with the credential
/// removed.
/// </remarks>
internal static class HttpExtensions
{
	/// <summary>
	/// Header names whose values carry a credential and must never be rendered into a log message or
	/// an exception message.
	/// </summary>
	/// <remarks>
	/// This client sends one of two credentials depending on configuration: an Authorization bearer
	/// token, or the API key in X-Cisco-Meraki-API-Key. The latter is the reason a list copied from a
	/// sibling package would not have fixed this one, and it is the more sensitive of the two because
	/// a Meraki API key does not expire.
	/// </remarks>
	private static readonly HashSet<string> SensitiveHeaderNames = new(StringComparer.OrdinalIgnoreCase)
	{
		"X-Cisco-Meraki-API-Key",
		"Authorization",
		"Proxy-Authorization",
		"Cookie",
		"Set-Cookie",
		"X-API-Key",
		"Api-Key",
		"X-Api-Token",
		"X-Auth-Token",
	};

	/// <summary>
	/// The subset of sensitive headers whose value is of the form "&lt;scheme&gt; &lt;credential&gt;",
	/// where the scheme is safe to keep and useful to see.
	/// </summary>
	private static readonly HashSet<string> SchemePrefixedHeaderNames = new(StringComparer.OrdinalIgnoreCase)
	{
		"Authorization",
		"Proxy-Authorization",
	};

	/// <summary>
	/// Whether a header name denotes a credential-bearing header.
	/// </summary>
	/// <remarks>
	/// The suffix test catches vendor-prefixed variants of the standard header, which an exact-match
	/// list alone would render verbatim.
	/// </remarks>
	private static bool IsSensitive(string name)
		=> SensitiveHeaderNames.Contains(name)
		|| name.EndsWith("Authorization", StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Whether a header's grammar is "&lt;scheme&gt; &lt;credential&gt;", so its scheme can be kept.
	/// </summary>
	private static bool IsSchemePrefixed(string name)
		=> SchemePrefixedHeaderNames.Contains(name)
		|| name.EndsWith("Authorization", StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Joins a header's values, replacing the credential with a redaction marker when the header is a
	/// sensitive one.
	/// </summary>
	/// <remarks>
	/// The authentication scheme and the credential length are preserved. That is enough to tell an
	/// engineer that a credential was sent and roughly what shape it had, which is all diagnosis needs,
	/// without writing the credential itself somewhere it will be retained and widely readable.
	/// </remarks>
	internal static string RedactIfSensitive(string name, IEnumerable<string> values)
	{
		var value = string.Join(", ", values);

		if (value.Length == 0 || !IsSensitive(name))
		{
			return value;
		}

		// Only headers whose grammar is "<scheme> <credential>" keep their scheme, so that which
		// authentication mechanism was used remains visible. Applying this to any header containing a
		// space would be unsafe: a cookie such as "session=abc123; HttpOnly" also contains one, and
		// treating the text before it as a scheme would preserve the very value being redacted.
		if (IsSchemePrefixed(name))
		{
			var schemeLength = value.IndexOf(' ', StringComparison.Ordinal);

			if (schemeLength > 0)
			{
				return $"{value[..schemeLength]} <redacted, length {value.Length - schemeLength - 1}>";
			}
		}

		return $"<redacted, length {value.Length}>";
	}

	/// <summary>
	/// Renders a request for diagnostic output, in the shape of <c>HttpRequestMessage.ToString()</c>
	/// but with credential-bearing header values redacted.
	/// </summary>
	internal static string ToRedactedString(this HttpRequestMessage request)
	{
		var stringBuilder = new StringBuilder()
			.Append("Method: ").Append(request.Method)
			.Append(", RequestUri: '").Append(request.RequestUri?.ToString() ?? "<null>")
			.Append("', Version: ").Append(request.Version)
			.Append(", Content: ").Append(request.Content?.GetType().FullName ?? "<null>")
			.AppendLine(", Headers:");

		AppendHeaders(stringBuilder, request.Headers, request.Content?.Headers);

		return stringBuilder.ToString();
	}

	/// <summary>
	/// Renders a response for diagnostic output, in the shape of <c>HttpResponseMessage.ToString()</c>
	/// but with credential-bearing header values redacted.
	/// </summary>
	internal static string ToRedactedString(this HttpResponseMessage response)
	{
		var stringBuilder = new StringBuilder()
			.Append("StatusCode: ").Append((int)response.StatusCode)
			.Append(", ReasonPhrase: '").Append(response.ReasonPhrase ?? "<null>")
			.Append("', Version: ").Append(response.Version)
			.Append(", Content: ").Append(response.Content?.GetType().FullName ?? "<null>")
			.AppendLine(", Headers:");

		AppendHeaders(stringBuilder, response.Headers, response.Content?.Headers);

		return stringBuilder.ToString();
	}

	/// <summary>
	/// Appends the message headers and, where present, the content headers, each redacted.
	/// </summary>
	private static void AppendHeaders(StringBuilder stringBuilder, HttpHeaders headers, HttpHeaders? contentHeaders)
	{
		_ = stringBuilder.AppendLine("{");

		foreach (var header in headers)
		{
			_ = stringBuilder.Append("  ").Append(header.Key).Append(": ").AppendLine(RedactIfSensitive(header.Key, header.Value));
		}

		if (contentHeaders is not null)
		{
			foreach (var header in contentHeaders)
			{
				_ = stringBuilder.Append("  ").Append(header.Key).Append(": ").AppendLine(RedactIfSensitive(header.Key, header.Value));
			}
		}

		_ = stringBuilder.Append('}');
	}
}
