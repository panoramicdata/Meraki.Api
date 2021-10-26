using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Set the detection ruleset 'connectivity'/'balanced'/'security' (optional - omitting will leave current config unchanged). Default value is 'balanced' if none currently saved
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SecurityIntrusionDetectionRuleSet
	{
		/// <summary>
		/// Enum Connectivity for "connectivity"
		/// </summary>
		[EnumMember(Value = "connectivity")]
		Connectivity = 1,

		/// <summary>
		/// Enum Balanced for "balanced"
		/// </summary>
		[EnumMember(Value = "balanced")]
		Balanced,

		/// <summary>
		/// Enum Security for "security"
		/// </summary>
		[EnumMember(Value = "security")]
		Security
	}
}
