namespace Meraki.Api.Data;

/// <summary>
/// Address of the interface
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClusterTunnelAddress
{
	/// <summary>
	/// Gateway of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "gateway")]
	public string Gateway { get; set; } = string.Empty;

	/// <summary>
	/// Protocol of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;

	/// <summary>
	/// Subnet mask of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnetMask")]
	public string SubnetMask { get; set; } = string.Empty;
}