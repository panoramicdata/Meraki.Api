namespace Meraki.Api.Data;
/// <summary>
/// Sensor Gateway Connections Latest Item Gateway
/// </summary>
[DataContract]

public class SensorGatewayConnectionsLatestItemGateway
{
	/// <summary>
	/// The MAC address of the gateway.
	/// </summary>
	[DataMember(Name = "mac")]
	[ApiAccess(ApiAccess.Read)]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The name of the gateway.
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Read)]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The serial number of the gateway.
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.Read)]
	public string Serial { get; set; } = string.Empty;
}