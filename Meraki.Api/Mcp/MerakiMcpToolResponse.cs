namespace Meraki.Api.Mcp;

/// <summary>
/// The transport-agnostic shape of an MCP tool result.
/// </summary>
/// <param name="IsError">True when the server flagged the result as an error.</param>
/// <param name="Text">The concatenated text content blocks, where any were returned.</param>
/// <param name="StructuredJson">The structured content as raw JSON, where any was returned.</param>
internal sealed record MerakiMcpToolResponse(
	bool IsError,
	string? Text,
	string? StructuredJson);
