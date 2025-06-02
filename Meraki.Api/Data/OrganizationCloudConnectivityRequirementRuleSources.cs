namespace Meraki.Api.Data;

/// <summary>
/// Firewall rule sources
/// </summary>
[DataContract]
public class OrganizationCloudConnectivityRequirementRuleSources
{
	/// <summary>
	/// If the source includes IP addresses in your networks
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "includeAddressesInYourNetworks")]
	public bool IncludeAddressesInYourNetworks { get; set; }

	/// <summary>
	/// A list of firewall rule source IP addresses
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationCloudConnectivityRequirementRuleSourcesAddress> Addresses { get; set; } = [];
}
