namespace Meraki.Api.Data;

/// <summary>
/// Product Type
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ProductType
{
	[EnumMember(Value = "wireless")]
	/// <summary>
	/// Wireless
	/// </summary>
	Wireless = 1,

	[EnumMember(Value = "appliance")]
	/// <summary>
	/// Appliance
	/// </summary>
	Appliance,

	[EnumMember(Value = "switch")]
	/// <summary>
	/// Switch
	/// </summary>
	Switch,

	[EnumMember(Value = "systemsManager")]
	/// <summary>
	/// Systems Manager
	/// </summary>
	SystemsManager,

	[EnumMember(Value = "camera")]
	/// <summary>
	/// Camera
	/// </summary>
	Camera,

	[EnumMember(Value = "cellularGateway")]
	/// <summary>
	/// Cellular Gateway
	/// </summary>
	CellularGateway,

	[EnumMember(Value = "sensor")]
	/// <summary>
	/// Sensor
	/// </summary>
	Sensor,

	/// <summary>
	/// Use sensor instead of environmental
	/// </summary>
	[Obsolete("Appears to have been replaced by sensor")]
	[EnumMember(Value = "environmental")]
	Environmental,

	[EnumMember(Value = "wired")]
	/// <summary>
	/// Wired
	/// </summary>
	Wired,

	[Obsolete("No longer available")]
	[EnumMember(Value = "vm_concentrator")]
	/// <summary>
	/// Vm Concentrator
	/// </summary>
	VmConcentrator,

	[EnumMember(Value = "phone")]
	/// <summary>
	/// Phone
	/// </summary>
	Phone,

	[EnumMember(Value = "frontizo")]
	/// <summary>
	/// Frontizo
	/// </summary>
	Frontizo,

	[EnumMember(Value = "secureConnect")]
	/// <summary>
	/// Secure Connect
	/// </summary>
	SecureConnect,

	[EnumMember(Value = "wirelessController")]
	/// <summary>
	/// Wireless Controller
	/// </summary>
	WirelessController
}
