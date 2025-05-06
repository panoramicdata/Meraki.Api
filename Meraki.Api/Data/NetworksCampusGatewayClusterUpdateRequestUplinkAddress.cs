namespace Meraki.Api.Data;

/// <summary>
/// Address of the interface
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestUplinkAddress
{
	/// <summary>
	/// Assignment mode of the interface
	/// </summary>
	[DataMember(Name = "assignmentMode")]
	[ApiAccess(ApiAccess.Update)]
	public NetworksCampusGatewayClusterUplinkIPAddressAssignmentMode AssignmentMode { get; set; }

	/// <summary>
	/// Gateway of the interface when assignmentMode is static
	/// </summary>
	[DataMember(Name = "gateway")]
	[ApiAccess(ApiAccess.Update)]
	public string? Gateway { get; set; }

	/// <summary>
	/// Protocol of the interface when assignmentMode is static
	/// </summary>
	[DataMember(Name = "protocol")]
	[ApiAccess(ApiAccess.Update)]
	public NetworksCampusGatewayClusterProtocol Protocol { get; set; }

	/// <summary>
	/// Subnet mask of the interface when assignmentMode is static
	/// </summary>
	[DataMember(Name = "subnetMask")]
	[ApiAccess(ApiAccess.Update)]
	public string? SubnetMask { get; set; }
}