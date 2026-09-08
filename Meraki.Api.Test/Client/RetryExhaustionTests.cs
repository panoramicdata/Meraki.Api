using Meraki.Api.Exceptions;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net;

namespace Meraki.Api.Test.Client;

/// <summary>
/// What the caller sees when every permitted attempt ends in a retryable status
/// (<see href="https://github.com/panoramicdata/Meraki.Api/issues/375">issue 375</see>).
/// No credentials or network are needed.
/// </summary>
public class RetryExhaustionTests
{
	private static readonly Uri RequestUri = new("https://api.meraki.com/api/v1/organizations");

	private static MerakiClientOptions Options(int maxAttemptCount, bool throwOnRetryExhaustion) => new()
	{
		ApiKey = "0000000000000000000000000000000000000000",
		UserAgent = "Meraki.Api.Test/1.0",
		MaxAttemptCount = maxAttemptCount,
		MaxBackOffDelaySeconds = 0,
		ThrowOnRetryExhaustion = throwOnRetryExhaustion
	};

	private static (HttpClient HttpClient, FixedStatusHandler Inner) CreateClient(MerakiClientOptions options, HttpStatusCode status)
	{
		var inner = new FixedStatusHandler(status);
		var merakiClient = new MerakiClient(options);
		var transport = new AuthenticatedBackingOffHttpClientHandler(options, merakiClient, NullLogger.Instance, inner);
		return (new HttpClient(transport), inner);
	}

	[Fact]
	public void ThrowOnRetryExhaustion_DefaultsToFalse()
		=> new MerakiClientOptions().ThrowOnRetryExhaustion.Should().BeFalse();

	[Fact]
	public async Task Exhaustion_ByDefault_ReturnsTheLastResponse()
	{
		var (httpClient, inner) = CreateClient(Options(maxAttemptCount: 3, throwOnRetryExhaustion: false), HttpStatusCode.TooManyRequests);

		using var response = await httpClient.GetAsync(RequestUri, TestContext.Current.CancellationToken);

		_ = response.StatusCode.Should().Be(HttpStatusCode.TooManyRequests);
		_ = inner.Attempts.Should().Be(3);
	}

	[Fact]
	public async Task Exhaustion_WhenOptedIn_ThrowsWithTheRetryDiagnostics()
	{
		var (httpClient, inner) = CreateClient(Options(maxAttemptCount: 3, throwOnRetryExhaustion: true), HttpStatusCode.TooManyRequests);

		var act = () => httpClient.GetAsync(RequestUri, TestContext.Current.CancellationToken);

		var exception = (await act.Should().ThrowAsync<RetryExhaustedException>()).Which;
		_ = exception.StatusCode.Should().Be(HttpStatusCode.TooManyRequests);
		_ = exception.AttemptCount.Should().Be(3);
		_ = exception.MaxAttemptCount.Should().Be(3);
		_ = exception.Elapsed.Should().BeGreaterThanOrEqualTo(TimeSpan.Zero);
		_ = exception.Method.Should().Be(HttpMethod.Get);
		_ = exception.RequestUri.Should().Be(RequestUri);
		_ = exception.Message.Should().Contain("3/3").And.Contain("429");
		_ = inner.Attempts.Should().Be(3);
	}

	[Theory]
	[InlineData(HttpStatusCode.BadGateway)]
	[InlineData(HttpStatusCode.ServiceUnavailable)]
	[InlineData(HttpStatusCode.GatewayTimeout)]
	public async Task Exhaustion_WhenOptedIn_AlsoThrowsForRetryableServerErrors(HttpStatusCode status)
	{
		// One attempt only: the 5xx path waits a fixed five seconds between attempts.
		var (httpClient, _) = CreateClient(Options(maxAttemptCount: 1, throwOnRetryExhaustion: true), status);

		var act = () => httpClient.GetAsync(RequestUri, TestContext.Current.CancellationToken);

		var exception = (await act.Should().ThrowAsync<RetryExhaustedException>()).Which;
		_ = exception.StatusCode.Should().Be(status);
		_ = exception.AttemptCount.Should().Be(1);
	}

	[Fact]
	public async Task NonRetryableStatus_WhenOptedIn_IsStillReturnedToTheCaller()
	{
		var (httpClient, inner) = CreateClient(Options(maxAttemptCount: 3, throwOnRetryExhaustion: true), HttpStatusCode.NotFound);

		using var response = await httpClient.GetAsync(RequestUri, TestContext.Current.CancellationToken);

		_ = response.StatusCode.Should().Be(HttpStatusCode.NotFound);
		_ = inner.Attempts.Should().Be(1);
	}

	[Fact]
	public async Task Success_WhenOptedIn_IsStillReturnedToTheCaller()
	{
		var (httpClient, inner) = CreateClient(Options(maxAttemptCount: 3, throwOnRetryExhaustion: true), HttpStatusCode.OK);

		using var response = await httpClient.GetAsync(RequestUri, TestContext.Current.CancellationToken);

		_ = response.StatusCode.Should().Be(HttpStatusCode.OK);
		_ = inner.Attempts.Should().Be(1);
	}

	/// <summary>
	/// Always answers with the same status, and Retry-After: 0 so the 429 path does not wait.
	/// </summary>
	private sealed class FixedStatusHandler(HttpStatusCode status) : HttpMessageHandler
	{
		public int Attempts { get; private set; }

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			Attempts++;
			var response = new HttpResponseMessage(status)
			{
				RequestMessage = request,
				Content = new StringContent("{}", System.Text.Encoding.UTF8, "application/json")
			};
			_ = response.Headers.TryAddWithoutValidation("Retry-After", "0");
			return Task.FromResult(response);
		}
	}
}
