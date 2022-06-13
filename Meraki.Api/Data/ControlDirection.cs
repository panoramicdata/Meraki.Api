namespace Meraki.Api.Data;

[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ControlDirection
{
	[EnumMember(Value = "both")]
	Both = 1,

	[EnumMember(Value = "inbound")]
	Inbound
}