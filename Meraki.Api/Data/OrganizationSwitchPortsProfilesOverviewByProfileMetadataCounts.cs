namespace Meraki.Api.Data;

/// <summary>
/// Counts of the result
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesOverviewByProfileMetadataCounts
{
	/// <summary>
	/// Meta data of the items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationSwitchPortsProfilesOverviewByProfileMetadataCountsItems Items { get; set; } = new();
}
