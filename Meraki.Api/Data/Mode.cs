using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Set mode to 'disabled'/'detection'/'prevention' (optional - omitting will leave current config unchanged)
	/// </summary>
	/// <value>Set mode to 'disabled'/'detection'/'prevention' (optional - omitting will leave current config unchanged)</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Mode
	{

		/// <summary>
		/// Enum Prevention for "prevention"
		/// </summary>
		[EnumMember(Value = "prevention")]
		Prevention,

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
}
