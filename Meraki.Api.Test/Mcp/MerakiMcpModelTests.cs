using Meraki.Api.Exceptions;
using Meraki.Api.Mcp;

namespace Meraki.Api.Test.Mcp;

public class MerakiMcpModelTests
{
	private sealed class Client
	{
		public string Description { get; set; } = string.Empty;
	}

	// ---------------------------------------------------------------- MerakiMcpResult

	[Fact]
	public void Deserialize_WithMatchingJson_ReturnsTheValue()
	{
		var result = new MerakiMcpResult
		{
			CapabilityId = "getNetworkClients",
			RawJson = """{"description":"Laptop"}"""
		};

		_ = result.Deserialize<Client>()!.Description.Should().Be("Laptop");
	}

	[Fact]
	public void Deserialize_WithUnknownMembersAndIgnore_Succeeds()
	{
		var result = new MerakiMcpResult
		{
			RawJson = """{"description":"Laptop","somethingCiscoAdded":true}"""
		};

		_ = result.Deserialize<Client>(JsonMissingMemberHandling.Ignore)!.Description.Should().Be("Laptop");
	}

	[Fact]
	public void Deserialize_WithUnknownMembersAndThrowOnError_Throws()
	{
		var result = new MerakiMcpResult
		{
			CapabilityId = "getNetworkClients",
			RawJson = """{"description":"Laptop","somethingCiscoAdded":true}"""
		};

		var act = () => result.Deserialize<Client>(JsonMissingMemberHandling.ThrowOnError);

		_ = act.Should().Throw<MerakiMcpProtocolException>().WithMessage("*getNetworkClients*");
	}

	[Theory]
	[InlineData("")]
	[InlineData("   ")]
	public void Deserialize_WithNoJson_Throws(string rawJson)
	{
		var result = new MerakiMcpResult { CapabilityId = "getOrganizations", RawJson = rawJson };

		var act = () => result.Deserialize<Client>();

		_ = act.Should().Throw<MerakiMcpProtocolException>().WithMessage("*no JSON content*");
	}

	[Fact]
	public void Deserialize_WithMalformedJson_ThrowsProtocolException()
	{
		var result = new MerakiMcpResult { CapabilityId = "getOrganizations", RawJson = "{not json" };

		var act = () => result.Deserialize<Client>();

		_ = act.Should().Throw<MerakiMcpProtocolException>();
	}

	[Fact]
	public void MerakiMcpResult_ToString_ReportsCapabilityAndSize()
		=> new MerakiMcpResult { CapabilityId = "getOrganizations", RawJson = "{}" }
			.ToString()
			.Should().Contain("getOrganizations").And.Contain("2");

	// ---------------------------------------------------------------- MerakiCapability

	[Fact]
	public void MerakiCapability_ToString_IncludesScoreWhenPresent()
		=> new MerakiCapability { CapabilityId = "getNetworkClients", Score = 0.5 }
			.ToString()
			.Should().Contain("getNetworkClients").And.Contain("0.500");

	[Fact]
	public void MerakiCapability_ToString_OmitsScoreWhenAbsent()
		=> new MerakiCapability { CapabilityId = "getNetworkClients" }
			.ToString()
			.Should().Be("getNetworkClients");

	[Fact]
	public void MerakiCapability_IsReadOperation_ReflectsTheCapabilityName()
	{
		_ = new MerakiCapability { CapabilityId = "getNetworkClients" }.IsReadOperation.Should().BeTrue();
		_ = new MerakiCapability { CapabilityId = "updateNetwork" }.IsReadOperation.Should().BeFalse();
	}

	// ---------------------------------------------------------------- statistics

	[Fact]
	public void Statistics_RecordAndReset()
	{
		var statistics = new MerakiMcpClientStatistics();

		statistics.RecordToolCall();
		statistics.RecordToolCall();
		statistics.RecordRetry(TimeSpan.FromMilliseconds(250));
		statistics.Http.RecordStatusCode(429, 10, 250);

		_ = statistics.ToolCallCount.Should().Be(2);
		_ = statistics.RetryCount.Should().Be(1);
		_ = statistics.TotalBackOffMs.Should().Be(250);
		_ = statistics.ToString().Should().Contain("Tool calls: 2").And.Contain("Retries: 1");

		statistics.Reset();

		_ = statistics.ToolCallCount.Should().Be(0);
		_ = statistics.RetryCount.Should().Be(0);
		_ = statistics.TotalBackOffMs.Should().Be(0);
		_ = statistics.Http.TotalRequestCount.Should().Be(0);
	}

	// ---------------------------------------------------------------- exceptions

	[Fact]
	public void Exceptions_ExposeTheStandardConstructors()
	{
		_ = new MerakiMcpException().Should().BeOfType<MerakiMcpException>();
		_ = new MerakiMcpException("message").Message.Should().Be("message");
		_ = new MerakiMcpException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		_ = new MerakiMcpProtocolException().Should().BeOfType<MerakiMcpProtocolException>();
		_ = new MerakiMcpProtocolException("message").Message.Should().Be("message");
		_ = new MerakiMcpProtocolException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		_ = new MerakiMcpTransportException().Should().BeOfType<MerakiMcpTransportException>();
		_ = new MerakiMcpTransportException("message").Message.Should().Be("message");
		_ = new MerakiMcpTransportException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		_ = new MerakiMcpAuthenticationException("message").Message.Should().Be("message");
		_ = new MerakiMcpAuthenticationException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		_ = new MerakiMcpAuthorizationException("message").Message.Should().Be("message");
		_ = new MerakiMcpAuthorizationException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		_ = new MerakiMcpRateLimitException().Should().BeOfType<MerakiMcpRateLimitException>();
		_ = new MerakiMcpRateLimitException("message").Message.Should().Be("message");
		_ = new MerakiMcpRateLimitException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		_ = new MerakiMcpToolNotFoundException().Should().BeOfType<MerakiMcpToolNotFoundException>();
		_ = new MerakiMcpToolNotFoundException("message").Message.Should().Be("message");
		_ = new MerakiMcpToolNotFoundException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		_ = new MerakiMcpReadOnlyViolationException().Should().BeOfType<MerakiMcpReadOnlyViolationException>();
		_ = new MerakiMcpReadOnlyViolationException("message").Message.Should().Be("message");
		_ = new MerakiMcpReadOnlyViolationException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();
	}

	[Fact]
	public void ToolNotFoundException_ListsWhatTheServerAdvertised()
	{
		var exception = new MerakiMcpToolNotFoundException("execute_api", ["semantic_search"]);

		_ = exception.ToolName.Should().Be("execute_api");
		_ = exception.AvailableToolNames.Should().ContainSingle();
		_ = exception.Message.Should().Contain("execute_api").And.Contain("semantic_search");
	}

	[Fact]
	public void ReadOnlyViolationException_ForCapability_NamesTheCapabilityAndTheRestClient()
	{
		var exception = MerakiMcpReadOnlyViolationException.ForCapability("updateNetworkSsid");

		_ = exception.CapabilityId.Should().Be("updateNetworkSsid");
		_ = exception.Message.Should().Contain("updateNetworkSsid").And.Contain(nameof(MerakiClient));
	}
}
