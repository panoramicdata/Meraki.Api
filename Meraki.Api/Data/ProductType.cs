namespace Meraki.Api.Data;

[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ProductType
{
	[EnumMember(Value = "wireless")]
	Wireless = 1,

	[EnumMember(Value = "appliance")]
	Appliance,

	[EnumMember(Value = "switch")]
	Switch,

	[EnumMember(Value = "systemsManager")]
	SystemsManager,

	[EnumMember(Value = "camera")]
	Camera,

	[EnumMember(Value = "cellularGateway")]
	CellularGateway,

	[EnumMember(Value = "sensor")]
	Sensor,

	/// <summary>
	/// Use sensor instead of environmental
	/// </summary>
	[Obsolete("Appears to have been replaced by sensor")]
	[EnumMember(Value = "environmental")]
	Environmental,

	[EnumMember(Value = "wired")]
	Wired,

	[Obsolete("No longer available")]
	[EnumMember(Value = "vm_concentrator")]
	VmConcentrator,

	[EnumMember(Value = "phone")]
	Phone,

	[EnumMember(Value = "frontizo")]
	Frontizo,

	[EnumMember(Value = "secureConnect")]
	SecureConnect
}