namespace Meraki.Api.Data;

/// <summary>
/// Networks Campus Gateway Cluster Protocol
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NetworksCampusGatewayClusterProtocol
{
	[EnumMember(Value = "ipv4")]
	/// <summary>
	/// Ipv4
	/// </summary>
	Ipv4
}
