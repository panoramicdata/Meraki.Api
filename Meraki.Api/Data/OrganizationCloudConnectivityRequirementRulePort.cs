namespace Meraki.Api.Data;

/// <summary>
/// Port object for firewall rules
/// </summary>
[DataContract]
public class OrganizationCloudConnectivityRequirementRulePort
{
	/// <summary>
	/// Port required for connectivity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public string Port { get; set; } = string.Empty;

	/// <summary>
	/// Protocols used for this purpose
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocols")]
	public List<string> Protocols { get; set; } = [];
}