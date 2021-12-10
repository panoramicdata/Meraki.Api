namespace Meraki.Api.Data;

/// <summary>
/// Alternate management interface
/// </summary>
[DataContract]
public class WirelessAlternateManagementInterface
{
	/// <summary>
	/// Boolean value to enable or disable alternate management interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Alternate management interface VLAN, must be between 1 and 4094
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlanId")]
	public int VlanId { get; set; }

	/// <summary>
	/// Can be one or more of the following values: 'radius', 'snmp', 'syslog' or 'ldap'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protocols")]
	public List<string> Protocols { get; set; } = new();

	/// <summary>
	/// Array of access point serial number and IP assignment. Note: accessPoints IP assignment is not applicable for template networks, in other words, do not put 'accessPoints' in the body when updating template networks. Also, an empty 'accessPoints' array will remove all previous static IP assignments
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "accessPoints")]
	public List<AccessPoints> AccessPoints { get; set; } = new();
}
