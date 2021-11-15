using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Set mode to 'disabled'/'detection'/'prevention' (optional - omitting will leave current config unchanged)
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SecurityIntrusionMode
{
	/// <summary>
	/// Enum Prevention for "prevention"
	/// </summary>
	[EnumMember(Value = "prevention")]
	Prevention = 1,

	/// <summary>
	/// Enum Detection for "detection"
	/// </summary>
	[EnumMember(Value = "detection")]
	Detection,

	/// <summary>
	/// Enum Disabled for "disabled"
	/// </summary>
	[EnumMember(Value = "disabled")]
	Disabled
}
