namespace Meraki.Api.Data;

/// <summary>
/// Uplink IP address of the device
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestDeviceUplinkAddress
{
	/// <summary> 
	/// IP address of the interface
	/// </summary>
	[DataMember(Name = "address")]
	[ApiAccess(ApiAccess.Update)]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Protocol of the interface
	/// </summary>
	[DataMember(Name = "protocol")]
	[ApiAccess(ApiAccess.Update)]
	public NetworksCampusGatewayClusterProtocol? Protocol { get; set; }
}