namespace Meraki.Api.Data;

/// <summary>
/// Organizaton Policy Object Group
/// </summary>
[DataContract]

public class OrganizationPolicyObjectsGroup : NamedIdentifiedItem
{
	/// <summary>
	/// Category of a policy object group (one of: NetworkObjectGroup, GeoLocationGroup, PortObjectGroup, ApplicationGroup)
	/// </summary>
	[DataMember(Name = "category")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public OrganizationPolicyObjectsGroupCategory? Category { get; set; }

	/// <summary>
	/// Created At
	/// </summary>
	[DataMember(Name = "created_at")]
	[ApiAccess(ApiAccess.Read)]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// Updaated At
	/// </summary>
	[DataMember(Name = "updated_at")]
	[ApiAccess(ApiAccess.Read)]
	public DateTime UpdatedAt { get; set; }

	/// <summary>
	/// A list of Policy Object ID's that this NetworkObjectGroup should be associated to
	/// </summary>
	[DataMember(Name = "objectIds")]
	[ApiAccess(ApiAccess.ReadWrite)]
	[ApiForeignKey(typeof(OrganizationPolicyObject))]
	public List<string>? ObjectIds { get; set; }

	/// <summary>
	/// Network Ids
	/// </summary>
	[DataMember(Name = "networkIds")]
	[ApiAccess(ApiAccess.Read)]
	public List<string>? NetworkIds { get; set; }
}