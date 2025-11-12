namespace Meraki.Api.Data;

/// <summary>
/// Multicast Routing
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum MulticastRouting
{
	[EnumMember(Value = "disabled")]
	/// <summary>
	/// Disabled
	/// </summary>
	Disabled = 1,

	[EnumMember(Value = "enabled")]
	/// <summary>
	/// Enabled
	/// </summary>
	Enabled,

	[EnumMember(Value = "IGMP snooping querier")]
	/// <summary>
	/// Igmp Snooping Querier
	/// </summary>
	IgmpSnoopingQuerier,
}
