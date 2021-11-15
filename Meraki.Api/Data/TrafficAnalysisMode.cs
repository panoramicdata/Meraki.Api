namespace Meraki.Api.Data;

/// <summary>
/// The traffic analysis mode for the network. Can be one of 'disabled' (do not collect traffic types), 'basic' (collect generic traffic categories), or 'detailed' (collect destination hostnames).
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TrafficAnalysisMode
{
	/// <summary>
	/// Enum Disabled for "disabled"
	/// </summary>
	[EnumMember(Value = "disabled")]
	Disabled,

	/// <summary>
	/// Enum Basic for "basic"
	/// </summary>
	[EnumMember(Value = "basic")]
	Basic,

	/// <summary>
	/// Enum Detailed for "detailed"
	/// </summary>
	[EnumMember(Value = "detailed")]
	Detailed
}
