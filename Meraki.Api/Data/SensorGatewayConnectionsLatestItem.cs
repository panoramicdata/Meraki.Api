namespace Meraki.Api.Data;
/// <summary>
/// Sensor Gateway Connections Latest Item
/// </summary>
[DataContract]

public class SensorGatewayConnectionsLatestItem
{
	/// <summary>
	/// Last reported RSSI value.
	/// </summary>
	[DataMember(Name = "rssi")]
	[ApiAccess(ApiAccess.Read)]
	public int Rssi { get; set; }

	/// <summary>
	/// Time, in ISO8601 format, when the sensor and gateway pair last connected.
	/// </summary>
	[DataMember(Name = "lastConnectedAt")]
	[ApiAccess(ApiAccess.Read)]
	public DateTime LastConnectedAt { get; set; }

	/// <summary>
	/// Time, in ISO8601 format, when RSSI was last reported for the sensor and gateway pair.
	/// </summary>
	[DataMember(Name = "lastReportedAt")]
	[ApiAccess(ApiAccess.Read)]
	public DateTime LastReportedAt { get; set; }

	/// <summary>
	/// Information about the gateway.
	/// </summary>
	[DataMember(Name = "gateway")]
	[ApiAccess(ApiAccess.Read)]
	public SensorGatewayConnectionsLatestItemGateway Gateway { get; set; } = new();

	/// <summary>
	/// Information about the network that the sensor and gateway are in.
	/// </summary>
	[DataMember(Name = "network")]
	[ApiAccess(ApiAccess.Read)]
	public SensorGatewayConnectionsLatestItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Information about the sensor.
	/// </summary>
	[DataMember(Name = "sensor")]
	[ApiAccess(ApiAccess.Read)]
	public SensorGatewayConnectionsLatestItemSensor Sensor { get; set; } = new();
}