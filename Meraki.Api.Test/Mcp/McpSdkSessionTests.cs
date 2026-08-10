using Meraki.Api.Mcp;
using ModelContextProtocol.Protocol;
using System.Text.Json;

namespace Meraki.Api.Test.Mcp;

/// <summary>
/// Drives the real ModelContextProtocol SDK client against an in-process MCP server, so the SDK
/// adapter, the initialize handshake, tools/list and tools/call are all genuinely exercised.
/// </summary>
public class McpSdkSessionTests
{
	private static MerakiMcpClient Create(InMemoryMcpServer server)
		=> new(
			new MerakiMcpClientOptions { ApiKey = "key" },
			null,
			ct => MerakiMcpClient.CreateSessionFromTransportAsync(server, ct));

	[Fact]
	public async Task InitializeAndListTools_CompleteTheRealHandshake()
	{
		var server = new InMemoryMcpServer();
		await using var client = Create(server);

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		status.IsConnected.Should().BeTrue();
		status.AvailableToolNames.Should().BeEquivalentTo(
			[MerakiMcpClient.SemanticSearchToolName, MerakiMcpClient.ExecuteApiToolName]);
		server.ReceivedMethods.Should().Contain("initialize").And.Contain("tools/list");
	}

	[Fact]
	public async Task SemanticSearch_OverTheRealSdk_ReturnsCapabilitiesFromTextContent()
	{
		var server = new InMemoryMcpServer
		{
			OnCallTool = _ => new CallToolResult
			{
				Content = [new TextContentBlock { Text = """{"capabilities":[{"capability_id":"getNetworkClients","score":0.9}]}""" }]
			}
		};

		await using var client = Create(server);

		var capabilities = await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		capabilities.Should().ContainSingle();
		capabilities[0].CapabilityId.Should().Be("getNetworkClients");
		capabilities[0].Score.Should().Be(0.9);
		server.ReceivedMethods.Should().Contain("tools/call");
	}

	[Fact]
	public async Task ExecuteApi_OverTheRealSdk_PrefersStructuredContent()
	{
		var server = new InMemoryMcpServer
		{
			OnCallTool = _ => new CallToolResult
			{
				Content = [new TextContentBlock { Text = "human readable" }],
				StructuredContent = JsonSerializer.Deserialize<JsonElement>("""{"clients":[{"id":"k1"}]}""")
			}
		};

		await using var client = Create(server);

		var result = await client.ExecuteApiAsync(
			"getNetworkClients",
			new Dictionary<string, object?> { ["networkId"] = "N_1" },
			TestContext.Current.CancellationToken);

		result.RawJson.Should().Contain("k1");
		result.Text.Should().Be("human readable");
	}

	[Fact]
	public async Task ExecuteApi_OverTheRealSdk_ConcatenatesMultipleTextBlocks()
	{
		var server = new InMemoryMcpServer
		{
			OnCallTool = _ => new CallToolResult
			{
				Content =
				[
					new TextContentBlock { Text = "first" },
					new TextContentBlock { Text = "second" }
				]
			}
		};

		await using var client = Create(server);

		var result = await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		result.Text.Should().Contain("first").And.Contain("second");
	}

	[Fact]
	public async Task ExecuteApi_OverTheRealSdk_WithNoContent_YieldsNoText()
	{
		var server = new InMemoryMcpServer
		{
			OnCallTool = _ => new CallToolResult { Content = [] }
		};

		await using var client = Create(server);

		var result = await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		result.Text.Should().BeNull();
		result.RawJson.Should().BeEmpty();
	}

	[Fact]
	public async Task ExecuteApi_OverTheRealSdk_PropagatesTheServerErrorFlag()
	{
		var server = new InMemoryMcpServer
		{
			OnCallTool = _ => new CallToolResult
			{
				IsError = true,
				Content = [new TextContentBlock { Text = "capability not found" }]
			}
		};

		await using var client = Create(server);

		var act = async () => await client.ExecuteApiAsync("getNoSuchThing", cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*capability not found*");
	}

	[Fact]
	public async Task ToolCatalogueDrift_OverTheRealSdk_IsReportedClearly()
	{
		var server = new InMemoryMcpServer();
		server.ToolNames.Clear();
		server.ToolNames.Add("meraki_search_v2");

		await using var client = Create(server);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		var exception = await act.Should().ThrowAsync<MerakiMcpToolNotFoundException>();
		exception.Which.AvailableToolNames.Should().ContainSingle().Which.Should().Be("meraki_search_v2");
	}

	[Fact]
	public async Task ServerSideJsonRpcError_IsTranslatedIntoAProtocolException()
	{
		var server = new InMemoryMcpServer
		{
			ListToolsError = "internal server failure"
		};

		await using var client = Create(server);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>();
	}

	[Fact]
	public async Task DisposeAsync_ClosesTheRealSdkSession()
	{
		var server = new InMemoryMcpServer();
		var client = Create(server);

		_ = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		await client.DisposeAsync();

		var act = async () => await client.GetStatusAsync(TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<ObjectDisposedException>();
	}
}
