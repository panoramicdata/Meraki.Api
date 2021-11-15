namespace Meraki.Api.Data;

[JsonConverter(typeof(StringEnumConverter))]
public enum Mode
{
	/// <summary>
	/// Enum Enabled for "enabled"
	/// </summary>
	[EnumMember(Value = "enabled")]
	Enabled = 1,

	/// <summary>
	/// Enum Disabled for "disabled"
	/// </summary>
	[EnumMember(Value = "disabled")]
	Disabled
}
