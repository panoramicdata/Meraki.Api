namespace Meraki.Api.Data;

/// <summary>
/// Networks Location Scanning Http Server Radio Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NetworksLocationScanningHttpServerRadioType
{
	/// <summary>
	/// Wifi
	/// </summary>
	[EnumMember(Value = "WiFi")]
	WiFi,

	/// <summary>
	/// Bluetooth Low Energy
	/// </summary>
	[EnumMember(Value = "BLE")]
	BLE
}
