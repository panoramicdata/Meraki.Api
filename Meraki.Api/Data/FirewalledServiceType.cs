using System.Runtime.Serialization;

namespace Meraki.Api.Data;

[DataContract]
public enum FirewalledServiceType
{
	[EnumMember(Value = "ICMP")]
	Icmp = 1,
	[EnumMember(Value = "web")]
	Web,
	[EnumMember(Value = "SNMP")]
	Snmp
}
