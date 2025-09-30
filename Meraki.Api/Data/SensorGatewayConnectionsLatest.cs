namespace Meraki.Api.Data;
/// <summary>
/// Sensor Gateway Connections Latest
/// </summary>
[DataContract]

public class SensorGatewayConnectionsLatest
	: ItemsResponseWithMeta<SensorGatewayConnectionsLatestItem>
{
	/// <summary>
	/// The organization's RSSI information between sensor-gateway pairs.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	public override List<SensorGatewayConnectionsLatestItem> Items { get; set; } = [];
}