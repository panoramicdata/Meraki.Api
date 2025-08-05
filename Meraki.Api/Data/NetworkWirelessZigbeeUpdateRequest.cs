namespace Meraki.Api.Data;

/// <summary>
/// Network Wireless Zigbee Update Request
/// </summary>
[DataContract]
public class NetworkWirelessZigbeeUpdateRequest
{
	/// <summary>
	/// To enable/disable Zigbee on the network
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Default Settings for Zigbee Devices
	/// </summary>
	[DataMember(Name = "defaults")]
	public NetworkWirelessZigbeeUpdateRequestDefaults? Defaults { get; set; }

	/// <summary>
	/// Zigbee's IoT controller details
	/// </summary>
	[DataMember(Name = "iotController")]
	public NetworkWirelessZigbeeUpdateRequestIotController? IotController { get; set; }

	/// <summary>
	/// Login Credentials of on-premises lock management
	/// </summary>
	[DataMember(Name = "lockManagement")]
	public NetworkWirelessZigbeeUpdateRequestLockManagement? LockManagement { get; set; }
}
