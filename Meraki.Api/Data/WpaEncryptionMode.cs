namespace Meraki.Api.Data;

/// <summary>
/// The types of WPA encryption. ('WPA1 only', 'WPA1 and WPA2', 'WPA2 only', 'WPA3 Transition Mode' or 'WPA3 only')
/// </summary>
/// <value>The types of WPA encryption. ('WPA1 only', 'WPA1 and WPA2', 'WPA2 only', 'WPA3 Transition Mode' or 'WPA3 only')</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum WpaEncryptionMode
{
	/// <summary>
	/// Enum WPA1only for "WPA1 only"
	/// </summary>
	[EnumMember(Value = "WPA1 only")]
	WPA1only,

	/// <summary>
	/// Enum WPA1andWPA2 for "WPA1 and WPA2"
	/// </summary>
	[EnumMember(Value = "WPA1 and WPA2")]
	WPA1andWPA2,

	/// <summary>
	/// Enum WPA2only for "WPA2 only"
	/// </summary>
	[EnumMember(Value = "WPA2 only")]
	WPA2only,

	/// <summary>
	/// Enum WPA3TransitionMode for "WPA3 Transition Mode"
	/// </summary>
	[EnumMember(Value = "WPA3 Transition Mode")]
	WPA3TransitionMode,

	/// <summary>
	/// Enum WPA3192BitSecurity for "WPA3 192-bit Security"
	/// </summary>
	[EnumMember(Value = "WPA3 192-bit Security")]
	WPA3192BitSecurity,

	/// <summary>
	/// Enum WPA3only for "WPA3 only"
	/// </summary>
	[EnumMember(Value = "WPA3 only")]
	WPA3only
}
