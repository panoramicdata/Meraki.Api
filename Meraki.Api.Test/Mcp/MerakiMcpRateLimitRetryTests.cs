using Meraki.Api.Mcp;

namespace Meraki.Api.Test.Mcp;

/// <summary>
/// Tests that Meraki Dashboard rate limiting reported in a tool payload is retried transparently
/// (issue #389).
/// </summary>
/// <remarks>
/// <para>
/// The server answers a rate-limited call with HTTP 200 and reports the rate limit inside the tool
/// payload, so <see cref="MerakiMcpBackingOffHttpMessageHandler"/> never sees a 429 and its retry
/// and back-off never engage. Before this fix the first rate-limited call failed outright, however
/// generous <c>MaxAttemptCount</c> was - confirmed against the live hosted server, which returned
/// <c>Retries: 0</c> alongside a rate-limit failure.
/// </para>
/// <para>
/// <c>MaxBackOffDelaySeconds</c> is zero throughout, so retries are immediate and these tests stay
/// fast while still exercising the real retry path.
/// </para>
/// </remarks>
public class MerakiMcpRateLimitRetryTests
{
	/// <summary>The shape the hosted server actually returns when the Dashboard rate limit is hit.</summary>
	private const string RateLimitPayload =
		"""{"result":{"type":"error","error":"Meraki API rate limit reached.","recovery_suggestion":"Try again shortly."}}""";

	private const string SuccessPayload =
		"""{"result":{"type":"success","capability_id":"getNetworkWirelessSsids","data":[{"number":0,"name":"Corporate"}]}}""";

	private static MerakiMcpClientOptions Options(int maxAttemptCount = 3)
		=> new()
		{
			ApiKey = "key",
			MaxAttemptCount = maxAttemptCount,
			MaxBackOffDelaySeconds = 0
		};

	private static MerakiMcpClient Create(FakeMerakiMcpSession session, int maxAttemptCount = 3)
		=> new(Options(maxAttemptCount), null, _ => Task.FromResult<IMerakiMcpSession>(session));

	// ---------------------------------------------------------------- message classification

	[Theory]
	[InlineData("Meraki API rate limit reached.", true)]
	[InlineData("MERAKI API RATE LIMIT REACHED", true)]
	[InlineData("rate-limit exceeded", true)]
	[InlineData("RateLimit hit", true)]
	[InlineData("Too many requests", true)]
	[InlineData("Received 429 from upstream", true)]
	[InlineData("Missing required parameters", false)]
	[InlineData("Capability not found", false)]
	[InlineData("", false)]
	[InlineData(null, false)]
	public void IsRateLimitMessage_ClassifiesCorrectly(string? message, bool expected)
		=> MerakiMcpClient.IsRateLimitMessage(message).Should().Be(expected);

	// ---------------------------------------------------------------- execute_api

	[Fact]
	public async Task ExecuteApiAsync_WhenRateLimitedThenSuccessful_ReturnsTheData()
	{
		var callCount = 0;
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) =>
			{
				callCount++;
				return Task.FromResult(new MerakiMcpToolResponse(
					false,
					callCount == 1 ? RateLimitPayload : SuccessPayload,
					null));
			}
		};

		await using var client = Create(session);

		var result = await client.ExecuteApiAsync("getNetworkWirelessSsids", parameters: null, TestContext.Current.CancellationToken);

		_ = callCount.Should().Be(2);
		_ = result.Payload.Should().Contain("Corporate");
	}

	[Fact]
	public async Task ExecuteApiAsync_WhenRateLimitedThenSuccessful_RecordsTheRetry()
	{
		var callCount = 0;
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) =>
			{
				callCount++;
				return Task.FromResult(new MerakiMcpToolResponse(
					false,
					callCount == 1 ? RateLimitPayload : SuccessPayload,
					null));
			}
		};

		await using var client = Create(session);

		_ = await client.ExecuteApiAsync("getNetworkWirelessSsids", parameters: null, TestContext.Current.CancellationToken);

		// Observability is part of the fix: a silent retry looks identical to a slow server.
		_ = client.Statistics.RetryCount.Should().Be(1);
	}

	[Fact]
	public async Task ExecuteApiAsync_WhenRateLimitedThroughout_ThrowsRateLimitExceptionAfterEveryAttempt()
	{
		var callCount = 0;
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) =>
			{
				callCount++;
				return Task.FromResult(new MerakiMcpToolResponse(false, RateLimitPayload, null));
			}
		};

		await using var client = Create(session, maxAttemptCount: 4);

		var act = async () => await client.ExecuteApiAsync("getNetworkWirelessSsids", parameters: null, TestContext.Current.CancellationToken);

		// The dedicated type, not MerakiMcpProtocolException: a caller that wants to back off and
		// come back later needs to distinguish "busy" from "malformed".
		_ = await act.Should().ThrowAsync<MerakiMcpRateLimitException>();
		_ = callCount.Should().Be(4);
	}

	[Fact]
	public async Task ExecuteApiAsync_WhenPayloadErrorIsNotARateLimit_FailsImmediatelyWithoutRetrying()
	{
		var callCount = 0;
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) =>
			{
				callCount++;
				return Task.FromResult(new MerakiMcpToolResponse(
					false,
					"""{"result":{"type":"error","error":"Missing required parameters","recovery_suggestion":"Provide values for: organizationId"}}""",
					null));
			}
		};

		await using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getNetworkWirelessSsids", parameters: null, TestContext.Current.CancellationToken);

		// Retrying a missing parameter would spend the very budget the retry logic protects.
		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>();
		_ = callCount.Should().Be(1);
	}

	[Fact]
	public async Task ExecuteApiAsync_WhenRateLimitArrivesViaTheMcpErrorFlag_IsAlsoRetried()
	{
		var callCount = 0;
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) =>
			{
				callCount++;
				return callCount == 1
					? Task.FromResult(new MerakiMcpToolResponse(true, "Meraki API rate limit reached.", null))
					: Task.FromResult(new MerakiMcpToolResponse(false, SuccessPayload, null));
			}
		};

		await using var client = Create(session);

		var result = await client.ExecuteApiAsync("getNetworkWirelessSsids", parameters: null, TestContext.Current.CancellationToken);

		// The server has been seen using the payload envelope, but the error flag is the documented
		// route and must behave the same way.
		_ = callCount.Should().Be(2);
		_ = result.Payload.Should().Contain("Corporate");
	}

	// ---------------------------------------------------------------- semantic_search

	[Fact]
	public async Task SemanticSearchAsync_WhenRateLimitedThenSuccessful_ReturnsTheCapabilities()
	{
		var callCount = 0;
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) =>
			{
				callCount++;
				return Task.FromResult(new MerakiMcpToolResponse(
					false,
					callCount == 1
						? RateLimitPayload
						: """{"results":[{"capability_id":"getNetworkWirelessSsids"}]}""",
					null));
			}
		};

		await using var client = Create(session);

		var capabilities = await client.SemanticSearchAsync("wireless ssids", TestContext.Current.CancellationToken);

		_ = callCount.Should().Be(2);
		_ = capabilities.Should().ContainSingle();
	}

	[Fact]
	public async Task SemanticSearchAsync_WhenRateLimitedThroughout_ThrowsRateLimitException()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, RateLimitPayload, null))
		};

		await using var client = Create(session, maxAttemptCount: 2);

		var act = async () => await client.SemanticSearchAsync("wireless ssids", TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<MerakiMcpRateLimitException>();
	}

	// ---------------------------------------------------------------- cancellation

	[Fact]
	public async Task ExecuteApiAsync_WhenCancelledDuringRetries_Throws()
	{
		using var cancellationTokenSource = new CancellationTokenSource();

		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) =>
			{
				cancellationTokenSource.Cancel();
				return Task.FromResult(new MerakiMcpToolResponse(false, RateLimitPayload, null));
			}
		};

		await using var client = Create(session, maxAttemptCount: 10);

		var act = async () => await client.ExecuteApiAsync(
			"getNetworkWirelessSsids",
			parameters: null,
			cancellationTokenSource.Token);

		// A long retry sequence must remain interruptible; the UI offers a cancel button.
		_ = await act.Should().ThrowAsync<OperationCanceledException>();
	}
}
