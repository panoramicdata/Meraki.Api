namespace Meraki.Api.Data;

/// <summary>
/// The appliance's handling of DHCP requests on this VLAN. One of: 'Run a DHCP server', 'Relay DHCP to another server' or 'Do not respond to DHCP requests'
/// </summary>
/// <value>The appliance's handling of DHCP requests on this VLAN. One of: 'Run a DHCP server', 'Relay DHCP to another server' or 'Do not respond to DHCP requests'</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum DhcpHandling
{
	/// <summary>
	/// Enum RunaDHCPserver for "Run a DHCP server"
	/// </summary>
	[EnumMember(Value = "Run a DHCP server")]
	RunaDHCPserver,

	/// <summary>
	/// Enum RelayDHCPtoanotherserver for "Relay DHCP to another server"
	/// </summary>
	[EnumMember(Value = "Relay DHCP to another server")]
	RelayDHCPtoanotherserver,

	/// <summary>
	/// Enum DonotrespondtoDHCPrequests for "Do not respond to DHCP requests"
	/// </summary>
	[EnumMember(Value = "Do not respond to DHCP requests")]
	DonotrespondtoDHCPrequests
}
