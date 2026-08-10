using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;

namespace Meraki.Api.Mcp;

/// <summary>
/// An <see cref="IMerakiMcpSession"/> backed by the official ModelContextProtocol SDK.
/// </summary>
internal sealed class McpSdkSession(
	McpClient client,
	IDisposable? ownedResource) : IMerakiMcpSession
{
	public async Task<IReadOnlyList<string>> ListToolNamesAsync(CancellationToken cancellationToken)
	{
		var tools = await client
			.ListToolsAsync(cancellationToken: cancellationToken)
			.ConfigureAwait(false);

		return [.. tools.Select(tool => tool.Name)];
	}

	public async Task<MerakiMcpToolResponse> CallToolAsync(
		string toolName,
		IReadOnlyDictionary<string, object?> arguments,
		CancellationToken cancellationToken)
	{
		var result = await client
			.CallToolAsync(toolName, arguments, cancellationToken: cancellationToken)
			.ConfigureAwait(false);

		var text = ExtractText(result);
		var structuredJson = result.StructuredContent?.GetRawText();

		return new MerakiMcpToolResponse(result.IsError ?? false, text, structuredJson);
	}

	private static string? ExtractText(CallToolResult result)
	{
		var blocks = result
			.Content
			.OfType<TextContentBlock>()
			.Select(block => block.Text)
			.Where(value => !string.IsNullOrEmpty(value))
			.ToList();

		return blocks.Count == 0
			? null
			: string.Join(Environment.NewLine, blocks);
	}

	public async ValueTask DisposeAsync()
	{
		await client.DisposeAsync().ConfigureAwait(false);
		ownedResource?.Dispose();
	}
}
