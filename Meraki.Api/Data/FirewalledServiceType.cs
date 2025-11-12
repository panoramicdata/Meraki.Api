namespace Meraki.Api.Data;

/// <summary>
/// Firewalled Service Type
/// </summary>
[DataContract]
public enum FirewalledServiceType
{
	/// <summary>
	/// Icmp
	/// </summary>
	[EnumMember(Value = "ICMP")]
	Icmp = 1,

	/// <summary>
	/// Web
	/// </summary>
	[EnumMember(Value = "web")]
	Web,

	/// <summary>
	/// Snmp
	/// </summary>
	[EnumMember(Value = "SNMP")]
	Snmp
}
