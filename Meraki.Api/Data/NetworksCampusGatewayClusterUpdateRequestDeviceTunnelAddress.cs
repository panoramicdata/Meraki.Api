namespace Meraki.Api.Data;

/// <summary>
/// Tunnel IP addresses of the device
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestDeviceTunnelAddress
{
	/// <summary>
	/// IP address of the interface
	/// </summary>
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Protocol of the interface
	/// </summary>
	[DataMember(Name = "protocol")]
	public NetworksCampusGatewayClusterProtocol Protocol { get; set; }
}