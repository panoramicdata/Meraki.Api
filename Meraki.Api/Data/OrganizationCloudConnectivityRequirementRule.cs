namespace Meraki.Api.Data;

/// <summary>
/// An object of source IP, destination IP, and ports required for connectivity
/// </summary>
[DataContract]
public class OrganizationCloudConnectivityRequirementRule
{
	/// <summary>
	/// Firewall rule destinations
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "destinations")]
	public OrganizationCloudConnectivityRequirementRuleDestinations Destinations { get; set; } = new();

	/// <summary>
	/// Firewall rule sources
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sources")]
	public OrganizationCloudConnectivityRequirementRuleSources Sources { get; set; } = new();

	/// <summary>
	/// Ports that are applied by this firewall rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<OrganizationCloudConnectivityRequirementRulePort> Ports { get; set; } = [];
}
