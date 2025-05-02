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
	[ApiAccess(ApiAccess.Create)]
	public NetworksCampusGatewayClusterUplinkIPAddressAssignmentMode AssignmentMode { get; set; }

	/// <summary>
	/// Gateway of the interface when assignment mode is static
	/// </summary>
	[DataMember(Name = "gateway")]
	[ApiAccess(ApiAccess.Create)]
	public string? Gateway { get; set; }

	/// <summary>
	/// Protocol of the interface when assignment mode is static
	/// </summary>
	[DataMember(Name = "protocol")]
	[ApiAccess(ApiAccess.Create)]
	public NetworksCampusGatewayClusterProtocol? Protocol { get; set; }

	/// <summary>
	/// Subnet mask of the interface when assignment mode is static
	/// </summary>
	[DataMember(Name = "subnetMask")]
	[ApiAccess(ApiAccess.Create)]
	public string? SubnetMask { get; set; }
}