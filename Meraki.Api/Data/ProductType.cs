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

	[EnumMember(Value = "environmental")]
	Environmental,

	[EnumMember(Value = "phone")]
	Phone
}