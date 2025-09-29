namespace Meraki.Api.Data;
/// <summary>
/// Sensor Gateway Connections Latest Item Sensor
/// </summary>
[DataContract]

public class SensorGatewayConnectionsLatestItemSensor
{
	/// <summary>
	/// The MAC address of the sensor.
	/// </summary>
	[DataMember(Name = "mac")]
	[ApiAccess(ApiAccess.Read)]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The name of the sensor.
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Read)]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The serial number of the sensor.
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.Read)]
	public string Serial { get; set; } = string.Empty;
}