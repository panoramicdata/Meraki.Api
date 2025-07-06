namespace Meraki.Api.Data;

/// <summary>
/// Consilience entity
/// </summary>
[DataContract]
public class OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseItem
{
	/// <summary>
	/// Infra Security Group Tag(sgt) value for Trustsec
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sgt")]
	public int Sgt { get; set; }

	/// <summary>
	/// Serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Nameservers of the cluster
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "nameservers")]
	public OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseItemNameservers Nameservers { get; set; } = new();

	/// <summary>
	/// Uplink setting of the cluster
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uplink")]
	public OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseItemUplink Uplink { get; set; } = new();
}
