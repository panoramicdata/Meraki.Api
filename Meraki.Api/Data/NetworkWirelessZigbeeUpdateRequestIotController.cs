namespace Meraki.Api.Data;

/// <summary>
/// Zigbee's IoT controller details
/// </summary>
[DataContract]
public class NetworkWirelessZigbeeUpdateRequestIotController
{
	/// <summary>
	/// Device Serial number
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }
}