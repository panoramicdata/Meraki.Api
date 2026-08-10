using Meraki.Api.Mcp;
using ModelContextProtocol;
using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Channels;

namespace Meraki.Api.Test.Mcp;

/// <summary>
/// A minimal in-process MCP server, connected to the client over an in-memory channel pair.
/// </summary>
/// <remarks>
/// This exercises the real ModelContextProtocol SDK client, including the initialize handshake,
/// tools/list and tools/call, so that the SDK adapter is genuinely covered without a network
/// listener or a child process.
/// </remarks>
internal sealed class InMemoryMcpServer : IClientTransport, ITransport
{
	private readonly Channel<JsonRpcMessage> _toClient = Channel.CreateUnbounded<JsonRpcMessage>();

	public string Name => "InMemoryMeraki";

	public string? SessionId => "in-memory-session";

	public ChannelReader<JsonRpcMessage> MessageReader => _toClient.Reader;

	/// <summary>
	/// The tools this server advertises.
	/// </summary>
	public List<string> ToolNames { get; } = [MerakiMcpClient.SemanticSearchToolName, MerakiMcpClient.ExecuteApiToolName];

	/// <summary>
	/// Produces the result for a tools/call request.
	/// </summary>
	public Func<string, CallToolResult> OnCallTool { get; set; } = _ => new CallToolResult
	{
		Content = [new TextContentBlock { Text = "{}" }]
	};

	/// <summary>
	/// When set, tools/list fails with this JSON-RPC error message.
	/// </summary>
	public string? ListToolsError { get; set; }

	public List<string> ReceivedMethods { get; } = [];

	public Task<ITransport> ConnectAsync(CancellationToken cancellationToken = default)
		=> Task.FromResult<ITransport>(this);

	public async Task SendMessageAsync(JsonRpcMessage message, CancellationToken cancellationToken = default)
	{
		if (message is not JsonRpcRequest request)
		{
			// Notifications need no reply.
			return;
		}

		ReceivedMethods.Add(request.Method);

		JsonRpcMessage reply = request.Method switch
		{
			"initialize" => Respond(request, new InitializeResult
			{
				ProtocolVersion = "2024-11-05",
				Capabilities = new ServerCapabilities { Tools = new ToolsCapability() },
				ServerInfo = new Implementation { Name = "InMemoryMeraki", Version = "1.0.0" }
			}),
			"tools/list" when ListToolsError is not null => new JsonRpcError
			{
				Id = request.Id,
				Error = new JsonRpcErrorDetail { Code = -32000, Message = ListToolsError }
			},
			"tools/list" => Respond(request, new ListToolsResult
			{
				Tools = [.. ToolNames.Select(name => new Tool { Name = name, Description = $"{name} tool" })]
			}),
			"tools/call" => Respond(request, OnCallTool(ReadToolName(request))),
			_ => new JsonRpcError
			{
				Id = request.Id,
				Error = new JsonRpcErrorDetail { Code = -32601, Message = $"Method '{request.Method}' not found." }
			}
		};

		await _toClient.Writer.WriteAsync(reply, cancellationToken);
	}

	private static string ReadToolName(JsonRpcRequest request)
		=> request.Params?["name"]?.GetValue<string>() ?? string.Empty;

	private static JsonRpcResponse Respond<T>(JsonRpcRequest request, T result)
		=> new()
		{
			Id = request.Id,
			Result = JsonSerializer.SerializeToNode<T>(result, McpJsonUtilities.DefaultOptions)
				?? throw new InvalidOperationException("Could not serialise the result.")
		};

	public ValueTask DisposeAsync()
	{
		_toClient.Writer.TryComplete();
		return ValueTask.CompletedTask;
	}
}
