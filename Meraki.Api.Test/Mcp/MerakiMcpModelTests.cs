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

		result.Deserialize<Client>()!.Description.Should().Be("Laptop");
	}

	[Fact]
	public void Deserialize_WithUnknownMembersAndIgnore_Succeeds()
	{
		var result = new MerakiMcpResult
		{
			RawJson = """{"description":"Laptop","somethingCiscoAdded":true}"""
		};

		result.Deserialize<Client>(JsonMissingMemberHandling.Ignore)!.Description.Should().Be("Laptop");
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

		act.Should().Throw<MerakiMcpProtocolException>().WithMessage("*getNetworkClients*");
	}

	[Theory]
	[InlineData("")]
	[InlineData("   ")]
	public void Deserialize_WithNoJson_Throws(string rawJson)
	{
		var result = new MerakiMcpResult { CapabilityId = "getOrganizations", RawJson = rawJson };

		var act = () => result.Deserialize<Client>();

		act.Should().Throw<MerakiMcpProtocolException>().WithMessage("*no JSON content*");
	}

	[Fact]
	public void Deserialize_WithMalformedJson_ThrowsProtocolException()
	{
		var result = new MerakiMcpResult { CapabilityId = "getOrganizations", RawJson = "{not json" };

		var act = () => result.Deserialize<Client>();

		act.Should().Throw<MerakiMcpProtocolException>();
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
		new MerakiCapability { CapabilityId = "getNetworkClients" }.IsReadOperation.Should().BeTrue();
		new MerakiCapability { CapabilityId = "updateNetwork" }.IsReadOperation.Should().BeFalse();
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

		statistics.ToolCallCount.Should().Be(2);
		statistics.RetryCount.Should().Be(1);
		statistics.TotalBackOffMs.Should().Be(250);
		statistics.ToString().Should().Contain("Tool calls: 2").And.Contain("Retries: 1");

		statistics.Reset();

		statistics.ToolCallCount.Should().Be(0);
		statistics.RetryCount.Should().Be(0);
		statistics.TotalBackOffMs.Should().Be(0);
		statistics.Http.TotalRequestCount.Should().Be(0);
	}

	// ---------------------------------------------------------------- exceptions

	[Fact]
	public void Exceptions_ExposeTheStandardConstructors()
	{
		new MerakiMcpException().Should().BeOfType<MerakiMcpException>();
		new MerakiMcpException("message").Message.Should().Be("message");
		new MerakiMcpException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		new MerakiMcpProtocolException().Should().BeOfType<MerakiMcpProtocolException>();
		new MerakiMcpProtocolException("message").Message.Should().Be("message");
		new MerakiMcpProtocolException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		new MerakiMcpTransportException().Should().BeOfType<MerakiMcpTransportException>();
		new MerakiMcpTransportException("message").Message.Should().Be("message");
		new MerakiMcpTransportException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		new MerakiMcpAuthenticationException("message").Message.Should().Be("message");
		new MerakiMcpAuthenticationException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		new MerakiMcpAuthorizationException("message").Message.Should().Be("message");
		new MerakiMcpAuthorizationException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		new MerakiMcpRateLimitException().Should().BeOfType<MerakiMcpRateLimitException>();
		new MerakiMcpRateLimitException("message").Message.Should().Be("message");
		new MerakiMcpRateLimitException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		new MerakiMcpToolNotFoundException().Should().BeOfType<MerakiMcpToolNotFoundException>();
		new MerakiMcpToolNotFoundException("message").Message.Should().Be("message");
		new MerakiMcpToolNotFoundException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();

		new MerakiMcpReadOnlyViolationException().Should().BeOfType<MerakiMcpReadOnlyViolationException>();
		new MerakiMcpReadOnlyViolationException("message").Message.Should().Be("message");
		new MerakiMcpReadOnlyViolationException("message", new InvalidOperationException()).InnerException.Should().NotBeNull();
	}

	[Fact]
	public void ToolNotFoundException_ListsWhatTheServerAdvertised()
	{
		var exception = new MerakiMcpToolNotFoundException("execute_api", ["semantic_search"]);

		exception.ToolName.Should().Be("execute_api");
		exception.AvailableToolNames.Should().ContainSingle();
		exception.Message.Should().Contain("execute_api").And.Contain("semantic_search");
	}

	[Fact]
	public void ReadOnlyViolationException_ForCapability_NamesTheCapabilityAndTheRestClient()
	{
		var exception = MerakiMcpReadOnlyViolationException.ForCapability("updateNetworkSsid");

		exception.CapabilityId.Should().Be("updateNetworkSsid");
		exception.Message.Should().Contain("updateNetworkSsid").And.Contain(nameof(MerakiClient));
	}
}
