namespace Meraki.Api.Data;

/// <summary>
/// The action to take when Unidirectional Link is detected (Alert only, Enforce). Default configuration is Alert only.
/// </summary>
/// <value>The action to take when Unidirectional Link is detected (Alert only, Enforce). Default configuration is Alert only.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum Udld
{
	/// <summary>
	/// Enum Alertonly for "Alert only"
	/// </summary>
	[EnumMember(Value = "Alert only")]
	Alertonly = 1,

	/// <summary>
	/// Enum Enforce for "Enforce"
	/// </summary>
	[EnumMember(Value = "Enforce")]
	Enforce
}
