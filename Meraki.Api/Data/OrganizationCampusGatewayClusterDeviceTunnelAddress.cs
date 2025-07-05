namespace Meraki.Api.Data;

/// <summary>
/// Tunnel IP address of the device
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClusterDeviceTunnelAddress
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
	public string Protocol { get; set; } = string.Empty;
}