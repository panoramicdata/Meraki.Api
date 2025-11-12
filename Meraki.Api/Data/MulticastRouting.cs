namespace Meraki.Api.Data;

/// <summary>
/// Multicast Routing
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum MulticastRouting
{
	[EnumMember(Value = "disabled")]
	Disabled = 1,

	[EnumMember(Value = "enabled")]
	Enabled,

	[EnumMember(Value = "IGMP snooping querier")]
	IgmpSnoopingQuerier,
}
