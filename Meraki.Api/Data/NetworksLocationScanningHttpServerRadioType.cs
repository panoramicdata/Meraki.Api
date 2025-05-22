namespace Meraki.Api.Data;

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