namespace Meraki.Api.Data;

/// <summary>
/// Traffic Shaping Vpn Exclusions Custom Protocol
/// </summary>
[DataContract]
public enum TrafficShapingVpnExclusionsCustomProtocol
{
	[EnumMember(Value = "any")]
	Any,

	[EnumMember(Value = "dns")]
	Dns,

	[EnumMember(Value = "icmp")]
	Icmp,

	[EnumMember(Value = "tcp")]
	Tcp,

	[EnumMember(Value = "udp")]
	Udp
}
