namespace Meraki.Api.Data;

/// <summary>
/// UpdateDeviceDeviceBluetoothSettings
/// </summary>
[DataContract]
public class DeviceBluetoothSettings
{
	/// <summary>
	/// Desired UUID of the beacon. If the value is set to null it will reset to Dashboard's automatically generated value.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "uuid")]
	public string Uuid { get; set; } = string.Empty;

	/// <summary>
	/// Desired major value of the beacon. If the value is set to null it will reset to Dashboard's automatically generated value.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "major")]
	public int? Major { get; set; }

	/// <summary>
	/// Desired minor value of the beacon. If the value is set to null it will reset to Dashboard's automatically generated value.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "minor")]
	public int? Minor { get; set; }

	/// <summary>
	/// Bluetooth transmit settings - Undocumented added 2025-10-21
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "transmit")]
	public DeviceBluetoothSettingsTransmit? Transmit { get; set; }
}
