namespace Meraki.Api.Data;

/// <summary>
/// Traffic Shaping Vpn Exclusions Custom Protocol
/// </summary>
[DataContract]
public enum TrafficShapingVpnExclusionsCustomProtocol
{
	/// <summary>
	/// Any
	/// </summary>
	[EnumMember(Value = "any")]
	Any,


	/// <summary>
	/// Dns
	/// </summary>
	[EnumMember(Value = "dns")]
	Dns,


	/// <summary>
	/// Icmp
	/// </summary>
	[EnumMember(Value = "icmp")]
	Icmp,


	/// <summary>
	/// Tcp
	/// </summary>
	[EnumMember(Value = "tcp")]
	Tcp,


	/// <summary>
	/// Udp
	/// </summary>
	[EnumMember(Value = "udp")]
	Udp
}
