namespace Meraki.Api.Data;

/// <summary>
/// Device Status
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DeviceStatus
{
	/// <summary>
	/// Alerting
	/// </summary>
	[EnumMember(Value = "alerting")]
	Alerting,

	/// <summary>
	/// Dormant
	/// </summary>
	[EnumMember(Value = "dormant")]
	Dormant,

	/// <summary>
	/// Offline
	/// </summary>
	[EnumMember(Value = "offline")]
	Offline,

	/// <summary>
	/// Online
	/// </summary>
	[EnumMember(Value = "online")]
	Online,
}