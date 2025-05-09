namespace Meraki.Api.Data;

/// <summary>
/// Counts of switches and ports associated with this profile
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesOverviewByProfileItemCounts
{
	/// <summary>
	/// Counts of switches and ports assigned to this profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assigned")]
	public OrganizationSwitchPortsProfilesOverviewByProfileItemCountsAssigned Assigned { get; set; } = new();

	/// <summary>
	/// The number of networks associated to this profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networksCount")]
	public OrganizationSwitchPortsProfilesOverviewByProfileItemCountsNetworksCount NetworksCount { get; set; } = new();
}
