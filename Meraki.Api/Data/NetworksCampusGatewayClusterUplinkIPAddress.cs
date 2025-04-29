namespace Meraki.Api.Data;

/// <summary>
/// Address of the interface
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUplinkIPAddress
{
	/// <summary>
	/// Assignment mode of the interface
	/// </summary>
	[DataMember(Name = "assignmentMode")]
	public NetworksCampusGatewayClusterUplinkIPAddressAssignmentMode AssignmentMode { get; set; }

	/// <summary>
	/// Gateway of the interface when assignment mode is static
	/// </summary>
	[DataMember(Name = "gateway")]
	public string? Gateway { get; set; }

	/// <summary>
	/// Protocol of the interface when assignment mode is static
	/// </summary>
	[DataMember(Name = "protocol")]
	public NetworksCampusGatewayClusterProtocol? Protocol { get; set; }

	/// <summary>
	/// Subnet mask of the interface when assignment mode is static
	/// </summary>
	[DataMember(Name = "subnetMask")]
	public string? SubnetMask { get; set; }
}