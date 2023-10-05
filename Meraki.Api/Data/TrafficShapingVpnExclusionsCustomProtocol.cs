namespace Meraki.Api.Data;

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
