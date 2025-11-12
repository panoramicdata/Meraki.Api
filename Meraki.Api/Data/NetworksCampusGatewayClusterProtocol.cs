namespace Meraki.Api.Data;

/// <summary>
/// Networks Campus Gateway Cluster Protocol
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NetworksCampusGatewayClusterProtocol
{
	/// <summary>
	/// Ipv4
	/// </summary>
	[EnumMember(Value = "ipv4")]
	Ipv4
}
