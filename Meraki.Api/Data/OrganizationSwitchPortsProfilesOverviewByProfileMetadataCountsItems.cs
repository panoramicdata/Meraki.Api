namespace Meraki.Api.Data;

/// <summary>
/// Meta data of the items
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesOverviewByProfileMetadataCountsItems
{
	/// <summary>
	/// Total number of switch port profiles
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}