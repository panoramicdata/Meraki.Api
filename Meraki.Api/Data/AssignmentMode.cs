namespace Meraki.Api.Data;

[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum AssignmentMode
{
	[EnumMember(Value = "eui-64")]
	Eui64 = 1,

	[EnumMember(Value = "static")]
	Static
}