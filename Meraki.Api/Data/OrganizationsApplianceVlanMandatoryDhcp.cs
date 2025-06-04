namespace Meraki.Api.Data;

/// <summary>
/// Mandatory DHCP will enforce that clients connecting to this VLAN must use the IP address assigned by the DHCP server. Clients who use a static IP address won't be able to associate. Only available on firmware versions 17.0 and above
/// </summary>
[DataContract]
public class OrganizationsApplianceVlanMandatoryDhcp
{
	/// <summary>
	/// Enable Mandatory DHCP on VLAN.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}