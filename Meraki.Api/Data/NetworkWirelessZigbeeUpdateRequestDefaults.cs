namespace Meraki.Api.Data;

/// <summary>
/// Default Settings for Zigbee Devices
/// </summary>
[DataContract]
public class NetworkWirelessZigbeeUpdateRequestDefaults
{
	/// <summary>
	/// Transmit Power Level
	/// </summary>
	[DataMember(Name = "transmitPowerLevel")]
	public int? TransmitPowerLevel { get; set; }

	/// <summary>
	/// Channel
	/// </summary>
	[DataMember(Name = "channel")]
	public string? Channel { get; set; }
}