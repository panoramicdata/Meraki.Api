using Meraki.Api.Exceptions;
using Meraki.Api.Mcp;

namespace Meraki.Api.Test.Mcp;

/// <summary>
/// Construction, read-only capability naming and semantic search.
/// </summary>
public partial class MerakiMcpClientTests
{
	private static MerakiMcpClientOptions Options(bool enforceReadOnly = true)
		=> new()
		{
			ApiKey = "key",
			EnforceReadOnlyCapabilityNames = enforceReadOnly
		};

	private static MerakiMcpClient Create(FakeMerakiMcpSession session, bool enforceReadOnly = true)
		=> new(Options(enforceReadOnly), null, _ => Task.FromResult<IMerakiMcpSession>(session));

	// ---------------------------------------------------------------- construction

	[Fact]
	public void Constructor_WithNullOptions_Throws()
	{
		var act = () => new MerakiMcpClient(null!);

		_ = act.Should().Throw<ArgumentNullException>();
	}

	[Fact]
	public void Constructor_WithInvalidOptions_ThrowsImmediately()
	{
		var act = () => new MerakiMcpClient(new MerakiMcpClientOptions());

		_ = act.Should().Throw<ConfigurationException>();
	}

	[Fact]
	public void Constructor_WithNullSessionFactory_Throws()
	{
		var act = () => new MerakiMcpClient(Options(), null, null!);

		_ = act.Should().Throw<ArgumentNullException>();
	}

	// ---------------------------------------------------------------- read-only naming

	[Theory]
	[InlineData("getNetworkClients", true)]
	[InlineData("GETNetworkClients", true)]
	[InlineData("getOrganizationDevicesStatuses", true)]
	[InlineData("updateNetworkSsid", false)]
	[InlineData("createNetwork", false)]
	[InlineData("deleteNetwork", false)]
	[InlineData("rebootDevice", false)]
	[InlineData("", false)]
	[InlineData(null, false)]
	public void IsReadCapabilityName_ClassifiesCorrectly(string? capabilityId, bool expected)
		=> MerakiMcpClient.IsReadCapabilityName(capabilityId).Should().Be(expected);

	// ---------------------------------------------------------------- semantic search

	[Fact]
	public async Task SemanticSearchAsync_WithStructuredContent_ReturnsRankedCapabilities()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""
				{
					"capabilities": [
						{ "capability_id": "getNetworkClients", "score": 0.93, "description": "List clients", "parameters": { "networkId": "string" } },
						{ "capability_id": "getNetworkEvents", "score": 0.71 }
					]
				}
				"""))
		};

		using var client = Create(session);

		var capabilities = await client.SemanticSearchAsync("which clients are on the network?", TestContext.Current.CancellationToken);

		_ = capabilities.Should().HaveCount(2);
		_ = capabilities[0].CapabilityId.Should().Be("getNetworkClients");
		_ = capabilities[0].Score.Should().Be(0.93);
		_ = capabilities[0].Description.Should().Be("List clients");
		_ = capabilities[0].ParameterSchemaJson.Should().Contain("networkId");
		_ = capabilities[0].IsReadOperation.Should().BeTrue();
		_ = capabilities[1].Score.Should().Be(0.71);
		_ = capabilities[1].Description.Should().BeNull();
		_ = capabilities[1].ParameterSchemaJson.Should().BeNull();
	}

	[Fact]
	public async Task SemanticSearchAsync_PassesQueryToTheTool()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, """[{"capability_id":"getNetworkClients"}]""", null))
		};

		using var client = Create(session);

		_ = await client.SemanticSearchAsync("wireless failures", TestContext.Current.CancellationToken);

		_ = session.Calls.Should().ContainSingle();
		_ = session.Calls[0].ToolName.Should().Be(MerakiMcpClient.SemanticSearchToolName);
		_ = session.Calls[0].Arguments["query"].Should().Be("wireless failures");
	}

	[Fact]
	public async Task SemanticSearchAsync_WithTextContentOnly_ParsesIt()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, """[{"capabilityId":"getDevice"}]""", null))
		};

		using var client = Create(session);

		var capabilities = await client.SemanticSearchAsync("device", TestContext.Current.CancellationToken);

		_ = capabilities.Should().ContainSingle().Which.CapabilityId.Should().Be("getDevice");
	}

	[Theory]
	[InlineData("""{"results":[{"id":"getNetworkClients"}]}""")]
	[InlineData("""{"data":[{"operationId":"getNetworkClients"}]}""")]
	[InlineData("""{"items":[{"capability":"getNetworkClients"}]}""")]
	[InlineData("""{"matches":[{"capability_id":"getNetworkClients"}]}""")]
	[InlineData("""{"somethingCiscoRenamed":[{"capability_id":"getNetworkClients"}]}""")]
	public async Task SemanticSearchAsync_ToleratesWrapperAndFieldNameVariations(string json)
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, json))
		};

		using var client = Create(session);

		var capabilities = await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		_ = capabilities.Should().ContainSingle().Which.CapabilityId.Should().Be("getNetworkClients");
	}

	[Fact]
	public async Task SemanticSearchAsync_SkipsEntriesWithoutACapabilityId()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""[{"description":"no id here"},{"capability_id":"getNetworkClients"}]"""))
		};

		using var client = Create(session);

		var capabilities = await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		_ = capabilities.Should().ContainSingle().Which.CapabilityId.Should().Be("getNetworkClients");
	}

	[Theory]
	[InlineData(null, null)]
	[InlineData("", null)]
	[InlineData("   ", null)]
	public async Task SemanticSearchAsync_WithNoContent_ThrowsProtocolException(string? text, string? structuredJson)
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, text, structuredJson))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*no content*");
	}

	[Fact]
	public async Task SemanticSearchAsync_WithUnparseableJson_ThrowsProtocolException()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, "this is not json", null))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*parse*");
	}

	[Fact]
	public async Task SemanticSearchAsync_WithNoArrayAnywhere_ThrowsProtocolException()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, """{"message":"nothing useful"}"""))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*capability array*");
	}

	[Fact]
	public async Task SemanticSearchAsync_WithEmptyCapabilityArray_ThrowsProtocolException()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, """{"capabilities":[]}"""))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*no recognisable capabilities*");
	}

	[Fact]
	public async Task SemanticSearchAsync_WhenServerFlagsAnError_ThrowsProtocolException()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(true, "quota exceeded", null))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*quota exceeded*");
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	[InlineData("  ")]
	public async Task SemanticSearchAsync_WithoutAQuery_Throws(string? query)
	{
		using var client = Create(new FakeMerakiMcpSession());

		var act = async () => await client.SemanticSearchAsync(query!, TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<ArgumentException>();
	}
}
