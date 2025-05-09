namespace Meraki.Api.Data;

/// <summary>
/// The number of networks associated to this profile
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesOverviewByProfileItemCountsNetworksCount
{
	/// <summary>
	/// The number of networks that are part of exclusion list
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "excluded")]
	public int Excluded { get; set; }

	/// <summary>
	/// The number of networks that are part of inclusion list
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "included")]
	public int Included { get; set; }
}