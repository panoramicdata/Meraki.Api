namespace Meraki.Api.Data;

/// <summary>
/// Organizaton Policy Objects Group Update Request
/// </summary>
[DataContract]

public class OrganizationPolicyObjectsGroupUpdateRequest : NamedItem
{
	/// <summary>
	/// Type of a policy object (one of: cidr, adaptivePolicyIpv4Cidr, fqdn, ipAndMask)
	/// </summary>
	[DataMember(Name = "objectIds")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<string>? ObjectIds { get; set; }
}