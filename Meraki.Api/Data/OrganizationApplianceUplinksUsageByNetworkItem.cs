namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Uplinks Usage By Network Item
/// </summary>
[DataContract]
public class OrganizationApplianceUplinksUsageByNetworkItem
{
	/// <summary>
	/// Network name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Network identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Uplink usage
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byUplink")]
	public List<OrganizationApplianceUplinksUsageByNetworkItemByUplinkItem> ByUplink { get; set; } = [];
}
