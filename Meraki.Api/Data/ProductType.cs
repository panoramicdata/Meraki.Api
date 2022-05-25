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
	/// Use sensor insead of environmental
	/// </summary>
	[Obsolete("Appears to have been replaced by sensor")]
	[EnumMember(Value = "environmental")]
	Environmental,

	[EnumMember(Value = "wired")]
	Wired
}