namespace Meraki.Api.Data;

/// <summary>
/// Address of the interface
/// </summary>
public class NetworksCampusGatewayClusterDeviceIPAddressWithGatewayDetailed
{
	/// <summary>
	/// Gateway of the interface
	/// </summary>
	[DataMember(Name = "gateway")]
	public string? Gateway { get; set; }

	/// <summary>
	/// Protocol of the interface
	/// </summary>
	[DataMember(Name = "protocol")]
	public NetworksCampusGatewayClusterProtocol? Protocol { get; set; }

	/// <summary>
	/// Subnet mask of the interface
	/// </summary>
	[DataMember(Name = "subnetMask")]
	public string? SubnetMask { get; set; }

}