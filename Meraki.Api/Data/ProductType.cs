namespace Meraki.Api.Data;

/// <summary>
/// Product Type
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ProductType
{
	/// <summary>
	/// Wireless
	/// </summary>
	[EnumMember(Value = "wireless")]
	Wireless = 1,


	/// <summary>
	/// Appliance
	/// </summary>
	[EnumMember(Value = "appliance")]
	Appliance,


	/// <summary>
	/// Switch
	/// </summary>
	[EnumMember(Value = "switch")]
	Switch,


	/// <summary>
	/// Systems Manager
	/// </summary>
	[EnumMember(Value = "systemsManager")]
	SystemsManager,


	/// <summary>
	/// Camera
	/// </summary>
	[EnumMember(Value = "camera")]
	Camera,


	/// <summary>
	/// Cellular Gateway
	/// </summary>
	[EnumMember(Value = "cellularGateway")]
	CellularGateway,


	/// <summary>
	/// Sensor
	/// </summary>
	[EnumMember(Value = "sensor")]
	Sensor,

	/// <summary>
	/// Use sensor instead of environmental
	/// </summary>
	[Obsolete("Appears to have been replaced by sensor")]
	[EnumMember(Value = "environmental")]
	Environmental,


	/// <summary>
	/// Wired
	/// </summary>
	[EnumMember(Value = "wired")]
	Wired,


	/// <summary>
	/// Vm Concentrator
	/// </summary>
	[Obsolete("No longer available")]
	[EnumMember(Value = "vm_concentrator")]
	VmConcentrator,


	/// <summary>
	/// Phone
	/// </summary>
	[EnumMember(Value = "phone")]
	Phone,


	/// <summary>
	/// Frontizo
	/// </summary>
	[EnumMember(Value = "frontizo")]
	Frontizo,


	/// <summary>
	/// Secure Connect
	/// </summary>
	[EnumMember(Value = "secureConnect")]
	SecureConnect,


	/// <summary>
	/// Wireless Controller
	/// </summary>
	[EnumMember(Value = "wirelessController")]
	WirelessController
}
