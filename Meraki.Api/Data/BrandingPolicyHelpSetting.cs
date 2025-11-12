namespace Meraki.Api.Data;

/// <summary>
/// Branding Policy Help Setting
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BrandingPolicyHelpSetting
{
	/// <summary>
	/// Enum Defaultorinherit for "default or inherit"
	/// </summary>
	[EnumMember(Value = "default or inherit")]
	DefaultOrInherit = 1,

	/// <summary>
	/// Enum Hide for "hide"
	/// </summary>
	[EnumMember(Value = "hide")]
	Hide,

	/// <summary>
	/// Enum Show for "show"
	/// </summary>
	[EnumMember(Value = "show")]
	Show
}
