using Meraki.Api.Exceptions;
using Meraki.Api.Mcp;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net;

namespace Meraki.Api.Test.Mcp;

public class MerakiMcpBackingOffHttpMessageHandlerTests
{
	/// <summary>
	/// A zero maximum back-off keeps these tests fast while still exercising the retry paths.
	/// </summary>
	private static MerakiMcpClientOptions Options(
		int maxAttemptCount = 3,
		MerakiMcpTransport transport = MerakiMcpTransport.HostedHttp)
		=> new()
		{
			ApiKey = "super-secret-key",
			UserAgent = "MerakiClient/1.0 PanoramicData",
			MaxAttemptCount = maxAttemptCount,
			MaxBackOffDelaySeconds = 0,
			Transport = transport,
			Uri = transport == MerakiMcpTransport.LocalHttp
				? "http://localhost:9999/mcp"
				: MerakiMcpClientOptions.DefaultHostedUri
		};

	private static async Task<HttpResponseMessage> SendAsync(
		StubHttpMessageHandler inner,
		MerakiMcpClientOptions options,
		MerakiMcpClientStatistics statistics,
		CancellationToken cancellationToken)
	{
		using var handler = new MerakiMcpBackingOffHttpMessageHandler(options, statistics, NullLogger.Instance)
		{
			InnerHandler = inner
		};

		using var httpClient = new HttpClient(handler);

		return await httpClient.PostAsync(new Uri("https://mcp.meraki.com/mcp"), new StringContent("{}"), cancellationToken);
	}

	[Fact]
	public async Task AttachesBearerTokenAndUserAgent()
	{
		var inner = new StubHttpMessageHandler().EnqueueStatus(HttpStatusCode.OK);
		var statistics = new MerakiMcpClientStatistics();

		using var response = await SendAsync(inner, Options(), statistics, TestContext.Current.CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		var authorization = inner.Requests[0].Headers.Authorization;
		authorization.Should().NotBeNull();
		authorization!.Scheme.Should().Be("Bearer");
		authorization.Parameter.Should().Be("super-secret-key");
		string.Join(" ", inner.Requests[0].Headers.GetValues("User-Agent"))
			.Should().Be("MerakiClient/1.0 PanoramicData");
	}

	[Fact]
	public async Task WithoutAUserAgent_DoesNotAddOne()
	{
		var options = Options();
		options.UserAgent = null;

		var inner = new StubHttpMessageHandler().EnqueueStatus(HttpStatusCode.OK);

		using var response = await SendAsync(inner, options, new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		inner.Requests[0].Headers.Contains("User-Agent").Should().BeFalse();
	}

	[Fact]
	public async Task Unauthorized_ThrowsAuthenticationExceptionWithoutRetrying()
	{
		var inner = new StubHttpMessageHandler().EnqueueStatus(HttpStatusCode.Unauthorized);

		var act = async () => await SendAsync(inner, Options(), new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpAuthenticationException>();
		inner.SendCount.Should().Be(1);
	}

	[Fact]
	public async Task Forbidden_ThrowsAuthorizationExceptionWithoutRetrying()
	{
		var inner = new StubHttpMessageHandler().EnqueueStatus(HttpStatusCode.Forbidden);

		var act = async () => await SendAsync(inner, Options(), new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpAuthorizationException>();
		inner.SendCount.Should().Be(1);
	}

	[Fact]
	public void UnauthorizedAndForbidden_AreDistinguishedFromOneAnother()
	{
		new MerakiMcpAuthenticationException().Message.Should().Contain("401");
		new MerakiMcpAuthorizationException().Message.Should().Contain("403");
	}

	[Fact]
	public async Task TooManyRequests_IsRetriedThenSucceeds()
	{
		var inner = new StubHttpMessageHandler()
			.EnqueueStatus(HttpStatusCode.TooManyRequests, retryAfter: "0")
			.EnqueueStatus(HttpStatusCode.OK);

		var statistics = new MerakiMcpClientStatistics();

		using var response = await SendAsync(inner, Options(), statistics, TestContext.Current.CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		inner.SendCount.Should().Be(2);
		statistics.RetryCount.Should().Be(1);
		statistics.Http.StatusCodeCounts.Should().ContainKey(429);
		statistics.Http.StatusCodeCounts.Should().ContainKey(200);
	}

	[Fact]
	public async Task TooManyRequests_WithNoRetryAfterHeader_StillRetries()
	{
		var inner = new StubHttpMessageHandler()
			.EnqueueStatus(HttpStatusCode.TooManyRequests)
			.EnqueueStatus(HttpStatusCode.OK);

		using var response = await SendAsync(inner, Options(), new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		inner.SendCount.Should().Be(2);
	}

	[Fact]
	public async Task TooManyRequests_WithUnparseableRetryAfterHeader_StillRetries()
	{
		var inner = new StubHttpMessageHandler()
			.EnqueueStatus(HttpStatusCode.TooManyRequests, retryAfter: "Wed, 21 Oct 2026 07:28:00 GMT")
			.EnqueueStatus(HttpStatusCode.OK);

		using var response = await SendAsync(inner, Options(), new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		inner.SendCount.Should().Be(2);
	}

	[Fact]
	public async Task TooManyRequests_Persisting_ThrowsRateLimitExceptionMentioningTheSharedBudget()
	{
		var inner = new StubHttpMessageHandler()
			.EnqueueStatus(HttpStatusCode.TooManyRequests, retryAfter: "0")
			.EnqueueStatus(HttpStatusCode.TooManyRequests, retryAfter: "0")
			.EnqueueStatus(HttpStatusCode.TooManyRequests, retryAfter: "0");

		var act = async () => await SendAsync(inner, Options(maxAttemptCount: 3), new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		var exception = await act.Should().ThrowAsync<MerakiMcpRateLimitException>();
		exception.Which.AttemptCount.Should().Be(3);
		exception.Which.Message.Should().Contain("10 requests per second per organization");
		inner.SendCount.Should().Be(3);
	}

	[Theory]
	[InlineData(HttpStatusCode.BadGateway)]
	[InlineData(HttpStatusCode.ServiceUnavailable)]
	[InlineData(HttpStatusCode.GatewayTimeout)]
	public async Task TransientServerErrors_AreRetriedThenSucceed(HttpStatusCode statusCode)
	{
		var options = Options();
		options.MaxBackOffDelaySeconds = 0;

		var inner = new StubHttpMessageHandler()
			.EnqueueStatus(statusCode)
			.EnqueueStatus(HttpStatusCode.OK);

		var statistics = new MerakiMcpClientStatistics();

		using var response = await SendAsync(inner, options, statistics, TestContext.Current.CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		inner.SendCount.Should().Be(2);
		statistics.RetryCount.Should().Be(1);
	}

	[Fact]
	public async Task TransientServerErrors_Persisting_ReturnTheFinalResponseRatherThanThrowing()
	{
		var inner = new StubHttpMessageHandler()
			.EnqueueStatus(HttpStatusCode.ServiceUnavailable)
			.EnqueueStatus(HttpStatusCode.ServiceUnavailable);

		using var response = await SendAsync(inner, Options(maxAttemptCount: 2), new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.ServiceUnavailable);
		inner.SendCount.Should().Be(2);
	}

	[Fact]
	public async Task NonRetryableStatusCodes_AreReturnedImmediately()
	{
		var inner = new StubHttpMessageHandler().EnqueueStatus(HttpStatusCode.BadRequest);

		using var response = await SendAsync(inner, Options(), new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
		inner.SendCount.Should().Be(1);
	}

	[Fact]
	public async Task InternalServerError_IsReturnedRatherThanRetried()
	{
		var inner = new StubHttpMessageHandler().EnqueueStatus(HttpStatusCode.InternalServerError);

		using var response = await SendAsync(inner, Options(), new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
		inner.SendCount.Should().Be(1);
	}

	[Fact]
	public async Task TransportFailure_IsRetriedThenSucceeds()
	{
		var inner = new StubHttpMessageHandler()
			.EnqueueThrow(new HttpRequestException("connection refused"))
			.EnqueueStatus(HttpStatusCode.OK);

		var statistics = new MerakiMcpClientStatistics();

		using var response = await SendAsync(inner, Options(), statistics, TestContext.Current.CancellationToken);

		response.StatusCode.Should().Be(HttpStatusCode.OK);
		statistics.RetryCount.Should().Be(1);
	}

	[Fact]
	public async Task TransportFailure_AgainstTheHostedServer_MentionsTheStaticEgressAddresses()
	{
		var inner = new StubHttpMessageHandler()
			.EnqueueThrow(new HttpRequestException("connection timed out"));

		var act = async () => await SendAsync(inner, Options(maxAttemptCount: 1), new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		var exception = await act.Should().ThrowAsync<MerakiMcpTransportException>();
		exception.Which.Message.Should().Contain("158.115.141.245").And.Contain("allowlisting");
	}

	[Fact]
	public async Task TransportFailure_AgainstASelfHostedServer_NamesTheConfiguredUri()
	{
		var inner = new StubHttpMessageHandler()
			.EnqueueThrow(new HttpRequestException("connection refused"));

		var act = async () => await SendAsync(
			inner,
			Options(maxAttemptCount: 1, transport: MerakiMcpTransport.LocalHttp),
			new MerakiMcpClientStatistics(),
			TestContext.Current.CancellationToken);

		var exception = await act.Should().ThrowAsync<MerakiMcpTransportException>();
		exception.Which.Message.Should().Contain("http://localhost:9999/mcp");
	}

	[Fact]
	public async Task NoSecretIsEverPresentInAnExceptionMessage()
	{
		var inner = new StubHttpMessageHandler()
			.EnqueueThrow(new HttpRequestException("connection timed out"));

		var act = async () => await SendAsync(inner, Options(maxAttemptCount: 1), new MerakiMcpClientStatistics(), TestContext.Current.CancellationToken);

		var exception = await act.Should().ThrowAsync<MerakiMcpTransportException>();
		exception.Which.ToString().Should().NotContain("super-secret-key");
	}

	[Fact]
	public async Task Cancellation_IsHonoured()
	{
		var inner = new StubHttpMessageHandler().EnqueueStatus(HttpStatusCode.OK);
		using var cancellationTokenSource = new CancellationTokenSource();
		await cancellationTokenSource.CancelAsync();

		var act = async () => await SendAsync(inner, Options(), new MerakiMcpClientStatistics(), cancellationTokenSource.Token);

		await act.Should().ThrowAsync<OperationCanceledException>();
	}

	[Fact]
	public void EgressIpAddresses_AreTheSixCiscoPublishes()
		=> MerakiMcpTransportException.HostedEgressIpAddresses.Should().BeEquivalentTo(
			[
				"158.115.141.245",
				"158.115.141.238",
				"158.115.141.209",
				"158.115.133.170",
				"158.115.133.139",
				"158.115.133.156"
			]);
}
