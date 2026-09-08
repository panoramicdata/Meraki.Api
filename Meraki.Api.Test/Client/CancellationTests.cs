using Microsoft.Extensions.Logging.Abstractions;
using System.Diagnostics;

namespace Meraki.Api.Test.Client;

/// <summary>
/// Cancellation behaviour of <see cref="AuthenticatedBackingOffHttpClientHandler"/>
/// (<see href="https://github.com/panoramicdata/Meraki.Api/issues/391">issue 391</see>).
/// The inner handler never answers, so the only way out of an attempt is a token.
/// No credentials or network are needed.
/// </summary>
public class CancellationTests
{
	private static readonly Uri RequestUri = new("https://api.meraki.com/api/v1/organizations");

	private static (HttpClient HttpClient, HangingHandler Inner) CreateClient(MerakiClientOptions options)
	{
		var inner = new HangingHandler();
		var merakiClient = new MerakiClient(options);
		var transport = new AuthenticatedBackingOffHttpClientHandler(options, merakiClient, NullLogger.Instance, inner);
		return (new HttpClient(transport), inner);
	}

	[Fact]
	public async Task CallerCancellation_AbortsAnInFlightAttempt_WithoutWaitingForTheInnerTimeout()
	{
		var options = new MerakiClientOptions
		{
			ApiKey = "0000000000000000000000000000000000000000",
			UserAgent = "Meraki.Api.Test/1.0",
			HttpClientInnerTimeoutSeconds = 5,
			MaxAttemptCount = 1
		};
		var (httpClient, inner) = CreateClient(options);
		using var callerCancellation = new CancellationTokenSource(TimeSpan.FromMilliseconds(200));
		var stopwatch = Stopwatch.StartNew();

		var act = () => httpClient.GetAsync(RequestUri, callerCancellation.Token);

		_ = await act.Should().ThrowAsync<OperationCanceledException>();
		stopwatch.Stop();
		_ = stopwatch.Elapsed.Should().BeLessThan(TimeSpan.FromSeconds(2),
			"the caller cancelled after 200ms and should not have to wait out the 5s inner timeout");
		_ = inner.Attempts.Should().Be(1);
	}

	[Fact]
	public async Task InnerTimeout_StillRetriesAndThenThrowsTimeoutException_WhenTheCallerHasNotCancelled()
	{
		var options = new MerakiClientOptions
		{
			ApiKey = "0000000000000000000000000000000000000000",
			UserAgent = "Meraki.Api.Test/1.0",
			HttpClientInnerTimeoutSeconds = 0.2,
			MaxAttemptCount = 2,
			MaxBackOffDelaySeconds = 0
		};
		var (httpClient, inner) = CreateClient(options);

		var act = () => httpClient.GetAsync(RequestUri, TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<TimeoutException>();
		_ = inner.Attempts.Should().Be(2);
	}

	/// <summary>
	/// Never responds. Completes only when the token it was handed is cancelled.
	/// </summary>
	private sealed class HangingHandler : HttpMessageHandler
	{
		public int Attempts { get; private set; }

		// S1172: the signature is HttpMessageHandler's, so the unused request cannot be removed.
#pragma warning disable S1172 // Unused method parameters should be removed
		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
#pragma warning restore S1172 // Unused method parameters should be removed
		{
			Attempts++;
			await Task.Delay(Timeout.InfiniteTimeSpan, cancellationToken).ConfigureAwait(false);
			throw new InvalidOperationException("Unreachable");
		}
	}
}
