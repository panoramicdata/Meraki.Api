namespace Meraki.Api.Data;

/// <summary>
/// Uplink setting of the device
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClusterDeviceUplink
{
	/// <summary>
	/// Uplink interface name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Uplink IP addresses of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationCampusGatewayClusterDeviceUplinkAddress> Addresses { get; set; } = [];
}
