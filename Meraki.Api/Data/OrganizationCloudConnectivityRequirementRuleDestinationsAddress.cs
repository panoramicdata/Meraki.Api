namespace Meraki.Api.Data;

/// <summary>
/// A firewall rule destination IP address
/// </summary>
[DataContract]
public class OrganizationCloudConnectivityRequirementRuleDestinationsAddress
{
	/// <summary>
	/// Firewall rule destination IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Firewall rule destination IP address type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public IpAddressFullType Type { get; set; }
}
