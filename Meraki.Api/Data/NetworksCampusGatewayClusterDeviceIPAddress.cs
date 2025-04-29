namespace Meraki.Api.Data;

/// <summary>
/// Tunnel IP address of the device
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterDeviceIPAddress
{
	/// <summary>
	/// IP address of the interface
	/// </summary>
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Protocol of the Interface
	/// </summary>
	[DataMember(Name = "protocol")]
	public NetworksCampusGatewayClusterProtocol Protocol { get; set; }
}
