namespace Meraki.Api.Data;

/// <summary>
/// Object of Associated Networks
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesOverviewByProfileItemNetworks
{
	/// <summary>
	/// Determines whether network is included or excluded in smart port profile based on isOrganizationWide Flag.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// List of Associated Networks
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "values")]
	public List<OrganizationSwitchPortsProfilesOverviewByProfileItemNetworksNetwork> Values { get; set; } = [];
}
