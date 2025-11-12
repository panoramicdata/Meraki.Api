namespace Meraki.Api.Data;

/// <summary>
/// Multicast Routing
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum MulticastRouting
{
	/// <summary>
	/// Disabled
	/// </summary>
	[EnumMember(Value = "disabled")]
	Disabled = 1,

	/// <summary>
	/// Enabled
	/// </summary>
	[EnumMember(Value = "enabled")]
	Enabled,

	/// <summary>
	/// Igmp Snooping Querier
	/// </summary>
	[EnumMember(Value = "IGMP snooping querier")]
	IgmpSnoopingQuerier,
}
