namespace Meraki.Api.Data;

/// <summary>
/// Address of the interface
/// </summary>
public class NetworksCampusGatewayClusterDeviceIPAddressWithGateway
{
	/// <summary>
	/// Gateway of the interface
	/// </summary>
	[DataMember(Name = "gateway")]
	public string Gateway { get; set; } = string.Empty;

	/// <summary>
	/// Protocol of the interface
	/// </summary>
	[DataMember(Name = "protocol")]
	public NetworksCampusGatewayClusterProtocol Protocol { get; set; }

}