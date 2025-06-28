namespace Meraki.Api.Data;

/// <summary>
/// Uplink setting of the cluster
/// </summary>
[DataContract]
public class OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseItemUplink
{
	/// <summary>
	/// VLAN of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

	/// <summary>
	/// Name of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Addresses of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseItemUplinkAddress> Addresses { get; set; } = [];
}
