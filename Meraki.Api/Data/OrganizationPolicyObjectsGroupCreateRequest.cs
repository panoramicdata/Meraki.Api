namespace Meraki.Api.Data;

/// <summary>
/// Organizaton Policy Objects Group Create Request
/// </summary>
[DataContract]

public class OrganizationPolicyObjectsGroupCreateRequest : NamedItem
{
	/// <summary>
	/// Category of a policy object group (one of: NetworkObjectGroup, GeoLocationGroup, PortObjectGroup, ApplicationGroup)
	/// </summary>
	[DataMember(Name = "category")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public OrganizationPolicyObjectsGroupCategory? Category { get; set; }

	/// <summary>
	/// Type of a policy object (one of: cidr, adaptivePolicyIpv4Cidr, fqdn, ipAndMask)
	/// </summary>
	[DataMember(Name = "objectIds")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<string>? ObjectIds { get; set; }
}