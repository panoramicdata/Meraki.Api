namespace Meraki.Api.Data;

/// <summary>
/// Prefix assignment on the VLAN
/// </summary>
[DataContract]
public class OrganizationsApplianceVlanIpv6PrefixAssignment
{
	/// <summary>
	/// Manual configuration of the IPv6 Appliance IP
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "staticApplianceIp6")]
	public string StaticApplianceIp6 { get; set; } = string.Empty;

	/// <summary>
	/// Manual configuration of a /64 prefix on the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "staticPrefix")]
	public string StaticPrefix { get; set; } = string.Empty;

	/// <summary>
	/// Auto assign a /64 prefix from the origin to the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "autonomous")]
	public bool Autonomous { get; set; }

	/// <summary>
	/// The origin of the prefix
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "origin")]
	public OrganizationsApplianceVlanIpv6PrefixAssignmentOrigin Origin { get; set; } = new();
}
