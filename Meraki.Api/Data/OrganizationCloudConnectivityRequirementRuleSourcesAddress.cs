namespace Meraki.Api.Data;

/// <summary>
/// Firewall rule source IP address
/// </summary>
[DataContract]
public class OrganizationCloudConnectivityRequirementRuleSourcesAddress
{
	/// <summary>
	/// Firewall rule source IP address 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Firewall rule source IP address type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public IpAddressType Type { get; set; }
}
