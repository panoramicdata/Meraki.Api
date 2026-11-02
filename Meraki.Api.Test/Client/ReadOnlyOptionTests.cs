using Microsoft.Extensions.Logging.Abstractions;

namespace Meraki.Api.Test.Client;

/// <summary>
/// <see cref="MerakiClientOptions.IsReadOnly"/> enforcement in <see cref="AuthenticatedBackingOffHttpClientHandler"/>.
/// No credentials or network are needed.
/// </summary>
public class ReadOnlyOptionTests
{
	private static readonly Uri RequestUri = new("https://api.meraki.com/api/v1/organizations");

	private static (HttpClient HttpClient, CountingHandler Inner) CreateClient(MerakiClientOptions options)
	{
		var inner = new CountingHandler();
		var merakiClient = new MerakiClient(options);
		var transport = new AuthenticatedBackingOffHttpClientHandler(options, merakiClient, NullLogger.Instance, inner);
		return (new HttpClient(transport), inner);
	}

	private static MerakiClientOptions Options() => new()
	{
		ApiKey = "0000000000000000000000000000000000000000",
		UserAgent = "Meraki.Api.Test/1.0",
		MaxAttemptCount = 1
	};

	[Fact]
	public void IsReadOnly_DefaultsToFalse()
		=> _ = new MerakiClientOptions().IsReadOnly.Should().BeFalse();

#pragma warning disable CS0618 // The obsolete alias is under test
	[Fact]
	public void ReadOnlyAlias_ReadsAndWritesIsReadOnly()
	{
		var options = new MerakiClientOptions { ReadOnly = true };

		_ = options.IsReadOnly.Should().BeTrue();
		options.IsReadOnly = false;
		_ = options.ReadOnly.Should().BeFalse();
	}
#pragma warning restore CS0618

	[Theory]
	[InlineData("POST")]
	[InlineData("PUT")]
	[InlineData("DELETE")]
	[InlineData("PATCH")]
	public async Task WriteRequest_WhenIsReadOnly_ThrowsBeforeSending(string method)
	{
		var options = Options();
		options.IsReadOnly = true;
		var (httpClient, inner) = CreateClient(options);

		var act = () => httpClient.SendAsync(new HttpRequestMessage(new HttpMethod(method), RequestUri), TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<InvalidOperationException>();
		_ = inner.Attempts.Should().Be(0);
	}

	[Fact]
	public async Task ReadRequest_WhenIsReadOnly_IsSent()
	{
		var options = Options();
		options.IsReadOnly = true;
		var (httpClient, inner) = CreateClient(options);

		using var response = await httpClient.GetAsync(RequestUri, TestContext.Current.CancellationToken);

		_ = response.IsSuccessStatusCode.Should().BeTrue();
		_ = inner.Attempts.Should().Be(1);
	}

	[Fact]
	public async Task IsReadOnly_IsReadOnEachRequest_NotOnceAtConstruction()
	{
		var options = Options();
		var (httpClient, inner) = CreateClient(options);
		using var first = await httpClient.PostAsync(RequestUri, new StringContent("{}"), TestContext.Current.CancellationToken);
		options.IsReadOnly = true;

		var act = () => httpClient.PostAsync(RequestUri, new StringContent("{}"), TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<InvalidOperationException>();
		_ = inner.Attempts.Should().Be(1);
	}

	private sealed class CountingHandler : HttpMessageHandler
	{
		public int Attempts { get; private set; }

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			Attempts++;
			return Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK) { Content = new StringContent("[]") });
		}
	}
}
