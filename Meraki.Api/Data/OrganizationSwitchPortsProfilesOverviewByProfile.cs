namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Profiles Overview by Profile
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesOverviewByProfile
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSwitchPortsProfilesOverviewByProfileMetadata Meta { get; set; } = new();

	/// <summary>
	/// Listing of Overview of switch port profiles in an organization
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsProfilesOverviewByProfileItem> Items { get; set; } = [];
}
