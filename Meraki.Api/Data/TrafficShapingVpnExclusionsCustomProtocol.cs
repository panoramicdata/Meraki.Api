namespace Meraki.Api.Data;

/// <summary>
/// Traffic Shaping Vpn Exclusions Custom Protocol
/// </summary>
[DataContract]
public enum TrafficShapingVpnExclusionsCustomProtocol
{
	[EnumMember(Value = "any")]
	/// <summary>
	/// Any
	/// </summary>
	Any,

	[EnumMember(Value = "dns")]
	/// <summary>
	/// Dns
	/// </summary>
	Dns,

	[EnumMember(Value = "icmp")]
	/// <summary>
	/// Icmp
	/// </summary>
	Icmp,

	[EnumMember(Value = "tcp")]
	/// <summary>
	/// Tcp
	/// </summary>
	Tcp,

	[EnumMember(Value = "udp")]
	/// <summary>
	/// Udp
	/// </summary>
	Udp
}
