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
	[ApiAccess(ApiAccess.CreateUpdate)]
	public NetworksCampusGatewayClusterUplinkIPAddressAssignmentMode AssignmentMode { get; set; }

	/// <summary>
	/// Gateway of the interface when assignment mode is static
	/// </summary>
	[DataMember(Name = "gateway")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public string? Gateway { get; set; }

	/// <summary>
	/// Protocol of the interface when assignment mode is static
	/// </summary>
	[DataMember(Name = "protocol")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public NetworksCampusGatewayClusterProtocol? Protocol { get; set; }

	/// <summary>
	/// Subnet mask of the interface when assignment mode is static
	/// </summary>
	[DataMember(Name = "subnetMask")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public string? SubnetMask { get; set; }
}