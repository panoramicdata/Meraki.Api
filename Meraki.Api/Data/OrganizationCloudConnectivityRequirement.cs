namespace Meraki.Api.Data;

/// <summary>
/// Organization Cloud Connectivity Requirement.
/// </summary>
[DataContract]
public class OrganizationCloudConnectivityRequirement
{
	/// <summary>
	/// Describes the purpose of this requirement
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Devices using this firewall rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productTypes")]
	public List<string> ProductTypes { get; set; } = [];

	/// <summary>
	/// An object of source IP, destination IP, and ports required for connectivity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rule")]
	public OrganizationCloudConnectivityRequirementRule Rule { get; set; } = new();
}
