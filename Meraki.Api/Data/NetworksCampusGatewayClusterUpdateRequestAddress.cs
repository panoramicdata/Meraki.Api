namespace Meraki.Api.Data;

/// <summary>
/// Addresses of the interface
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestAddress
{
	/// <summary>
	/// Gateway of the interface
	/// </summary>
	[DataMember(Name = "gateway")]
	[ApiAccess(ApiAccess.Update)]
	public string? Gateway { get; set; }

	/// <summary>
	/// Protocol of the interface
	/// </summary>
	[DataMember(Name = "protocol")]
	[ApiAccess(ApiAccess.Update)]
	public NetworksCampusGatewayClusterProtocol Protocol { get; set; }

	/// <summary>
	/// Subnet mask of the interface
	/// </summary>
	[DataMember(Name = "subnetMask")]
	[ApiAccess(ApiAccess.Update)]
	public string? SubnetMask { get; set; }
}