namespace Meraki.Api.Data;

/// <summary>
/// Represents the type of a device or model in the system.
/// </summary>
public enum ModelType
{
	/// <summary>
	/// Represents an unknown or unspecified state or value.
	/// </summary>
	Unknown = 1,

	/// <summary>
	/// Camera
	/// </summary>
	Camera,

	/// <summary>
	/// Switch
	/// </summary>
	Switch,

	/// <summary>
	/// Cellular gateway
	/// </summary>
	Cellular,

	/// <summary>
	/// Wireless LAN
	/// </summary>
	WirelessLan,

	/// <summary>
	/// Mobile Device Management
	/// </summary>
	MobileDeviceManagement,

	/// <summary>
	/// Sensor
	/// </summary>
	Sensor,

	/// <summary>
	/// Appliance
	/// </summary>
	Appliance,

	/// <summary>
	/// Cisco Secure Connect
	/// </summary>
	CiscoSecureConnect
}
