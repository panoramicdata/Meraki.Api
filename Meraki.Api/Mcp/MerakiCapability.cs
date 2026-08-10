namespace Meraki.Api.Mcp;

/// <summary>
/// A Meraki Dashboard API capability returned by the MCP server's semantic_search tool.
/// </summary>
public class MerakiCapability
{
	/// <summary>
	/// The capability identifier, for example "getNetworkClients". Pass this to
	/// <see cref="MerakiMcpClient.ExecuteApiAsync"/>.
	/// </summary>
	public string CapabilityId { get; set; } = string.Empty;

	/// <summary>
	/// The relevance score the server assigned to this capability for the query, where the server
	/// supplied one.
	/// </summary>
	public double? Score { get; set; }

	/// <summary>
	/// A human-readable description of the capability, where the server supplied one.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// The parameter schema for the capability as raw JSON, where the server supplied one.
	/// </summary>
	public string? ParameterSchemaJson { get; set; }

	/// <summary>
	/// True when <see cref="CapabilityId"/> names a read operation.
	/// </summary>
	/// <remarks>
	/// Every Meraki Dashboard GET operation identifier begins with "get".
	/// </remarks>
	public bool IsReadOperation => MerakiMcpClient.IsReadCapabilityName(CapabilityId);

	/// <summary>
	/// Returns a string representation of the capability.
	/// </summary>
	/// <returns>The capability identifier and score.</returns>
	public override string ToString()
		=> Score.HasValue
			? $"{CapabilityId} ({Score.Value:N3})"
			: CapabilityId;
}
