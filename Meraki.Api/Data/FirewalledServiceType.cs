namespace Meraki.Api.Data;

/// <summary>
/// Firewalled Service Type
/// </summary>
[DataContract]
public enum FirewalledServiceType
{
	[EnumMember(Value = "ICMP")]
	/// <summary>
	/// Icmp
	/// </summary>
	Icmp = 1,
	[EnumMember(Value = "web")]
	/// <summary>
	/// Web
	/// </summary>
	Web,
	[EnumMember(Value = "SNMP")]
	/// <summary>
	/// Snmp
	/// </summary>
	Snmp
}
