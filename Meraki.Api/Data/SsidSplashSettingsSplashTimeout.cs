namespace Meraki.Api.Data;

/// <summary>
/// Splash timeout in minutes.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SsidSplashSettingsSplashTimeout
{
	/// <summary>
	/// Enum for "30"
	/// </summary>
	[EnumMember(Value = "30")]
	Minutes30,

	/// <summary>
	/// Enum for "60"
	/// </summary>
	[EnumMember(Value = "60")]
	Minutes60,

	/// <summary>
	/// Enum for "120"
	/// </summary>
	[EnumMember(Value = "120")]
	Miinutes120,

	/// <summary>
	/// Enum for "240"
	/// </summary>
	[EnumMember(Value = "240")]
	Minutes240,

	/// <summary>
	/// Enum for "480"
	/// </summary>
	[EnumMember(Value = "480")]
	Minutes480,

	/// <summary>
	/// Enum for "720"
	/// </summary>
	[EnumMember(Value = "720")]
	Minutes720,

	/// <summary>
	/// Enum for "1080"
	/// </summary>
	[EnumMember(Value = "1080")]
	Minutes1080,

	/// <summary>
	/// Enum for "1440"
	/// </summary>
	[EnumMember(Value = "1440")]
	Minutes1440,

	/// <summary>
	/// Enum for "2880"
	/// </summary>
	[EnumMember(Value = "2880")]
	Minutes2880,

	/// <summary>
	/// Enum for "5760"
	/// </summary>
	[EnumMember(Value = "5760")]
	Minutes5760,

	/// <summary>
	/// Enum for "7200"
	/// </summary>
	[EnumMember(Value = "7200")]
	Minutes7200,

	/// <summary>
	/// Enum for "10080"
	/// </summary>
	[EnumMember(Value = "10080")]
	Minutes10080,

	/// <summary>
	/// Enum for "20160"
	/// </summary>
	[EnumMember(Value = "20160")]
	Minutes20160,

	/// <summary>
	/// Enum for "43200"
	/// </summary>
	[EnumMember(Value = "43200")]
	Minutes43200,

	/// <summary>
	/// Enum for "86400"
	/// </summary>
	[EnumMember(Value = "86400")]
	Minutes86400,

	/// <summary>
	/// Enum for "129600"
	/// </summary>
	[EnumMember(Value = "129600")]
	Minutes129600
}