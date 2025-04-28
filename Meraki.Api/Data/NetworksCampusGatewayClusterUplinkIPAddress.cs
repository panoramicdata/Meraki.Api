namespace Meraki.Api.Data;

/// <summary>
/// Address of the interface
/// </summary>
public class NetworksCampusGatewayClusterUplinkIPAddress
{
	/// <summary>
	/// Assignment mode of the interface
	/// </summary>
	public NetworksCampusGatewayClusterUplinkIPAddressAssignmentMode AssignmentMode { get; set; }

	/// <summary>
	/// Gateway of the interface when assignment mode is static
	/// </summary>
	public string? Gateway { get; set; }

	/// <summary>
	/// Protocol of the interface when assignment mode is static
	/// </summary>
	public NetworksCampusGatewayClusterProtocol? Protocol { get; set; }

	/// <summary>
	/// Subnet mask of the interface when assignment mode is static
	/// </summary>
	public string? SubnetMask { get; set; }
}