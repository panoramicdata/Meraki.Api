namespace Meraki.Api.Data;

/// <summary>
/// IPv6 configuration on the VLAN
/// </summary>
[DataContract]
public class OrganizationsApplianceVlanIpv6
{
	/// <summary>
	/// Enable IPv6 on VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Prefix assignments on the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "prefixAssignments")]
	public List<OrganizationsApplianceVlanIpv6PrefixAssignment> PrefixAssignments { get; set; } = [];
}
