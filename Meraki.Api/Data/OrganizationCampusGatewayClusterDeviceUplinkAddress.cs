namespace Meraki.Api.Data;

/// <summary>
/// Uplink IP address of the device
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClusterDeviceUplinkAddress
{
	/// <summary>
	/// IP address of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Protocol of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;
}