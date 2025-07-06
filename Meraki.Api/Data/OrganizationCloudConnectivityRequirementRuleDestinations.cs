namespace Meraki.Api.Data;

/// <summary>
/// Firewall rule destinations
/// </summary>
[DataContract]
public class OrganizationCloudConnectivityRequirementRuleDestinations
{
	/// <summary>
	/// If the destination IP includes IP address in your networks
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "includeAddressesInYourNetworks")]
	public bool IncludeAddressesInYourNetworks { get; set; }

	/// <summary>
	/// If the destination IP includes any address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "includeAnyAddress")]
	public bool IncludeAnyAddress { get; set; }

	/// <summary>
	/// A list of firewall rule destination IP addresses
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationCloudConnectivityRequirementRuleDestinationsAddress> Addresses { get; set; } = [];
}
