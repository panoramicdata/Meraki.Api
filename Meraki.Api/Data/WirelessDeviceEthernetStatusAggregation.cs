namespace Meraki.Api.Data;

/// <summary>
/// Wireless Device Ethernet Status Link Aggregation
/// </summary>
[DataContract]
public class WirelessDeviceEthernetStatusAggregation
{
	/// <summary>
	/// Link Aggregation Speed
	/// </summary>
	[DataMember(Name = "speed")]
	public int Speed { get; set; }

	/// <summary>
	/// Link Aggregation Enabled Flag
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
