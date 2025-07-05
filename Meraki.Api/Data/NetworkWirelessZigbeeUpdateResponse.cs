namespace Meraki.Api.Data;

/// <summary>
/// Network Wireless Zigbee Update Response
/// </summary>
[DataContract]
public class NetworkWirelessZigbeeUpdateResponse
{
	/// <summary>
	/// If Zigbee is enabled for the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Default Settings for the MRs in network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "defaults")]
	public NetworkWirelessZigbeeUpdateResponseDefaults Defaults { get; set; } = new();

	/// <summary>
	/// Device details setup the IoT controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "iotController")]
	public NetworkWirelessZigbeeUpdateResponseIotController IotController { get; set; } = new();

	/// <summary>
	/// Lock Management Details
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lockManagement")]
	public NetworkWirelessZigbeeUpdateResponseLockManagement LockManagement { get; set; } = new();

	/// <summary>
	/// Network details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public NetworkWirelessZigbeeUpdateResponseNetwork Network { get; set; } = new();
}
