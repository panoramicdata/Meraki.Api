namespace Meraki.Api.Data;

[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum MulticastRouting
{
	// Default value is disabled so this has been left to enumerate to 0
	[EnumMember(Value = "disabled")]
	Disabled,

	[EnumMember(Value = "enabled")]
	Enabled,

	[EnumMember(Value = "IGMP snooping querier")]
	IgmpSnoopingQuerier,
}