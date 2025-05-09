namespace Meraki.Api.Data;

/// <summary>
/// Profile overview of a switch port in an organization
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesOverviewByProfileItem
{
	/// <summary>
	/// RBAC -> access computed based on current user's administered networks & associated networks w.r.t switch port profiles
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "access")]
	public string Access { get; set; } = string.Empty;

	/// <summary>
	/// When the port profile was created.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// The text describing the profile.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The name of the profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// ID of the profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "profileId")]
	public string ProfileId { get; set; } = string.Empty;

	/// <summary>
	/// When the port profile was updated.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedAt")]
	public string UpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not this profile is a organization wide profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "isOrganizationWide")]
	public bool IsOrganizationWide { get; set; }

	/// <summary>
	/// Counts of switches and ports associated with this profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchPortsProfilesOverviewByProfileItemCounts Counts { get; set; } = new();

	/// <summary>
	/// Network attributes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationSwitchPortsProfilesOverviewByProfileItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Object of Associated Networks
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networks")]
	public OrganizationSwitchPortsProfilesOverviewByProfileItemNetworks Networks { get; set; } = new();
}
