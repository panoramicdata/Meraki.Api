using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Set mode to 'enabled' to enable malware prevention, otherwise 'disabled'
	/// </summary>
	/// <value>Set mode to 'enabled' to enable malware prevention, otherwise 'disabled'</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnabledDisabledMode
	{
		/// <summary>
		/// Enum Enabled for "enabled"
		/// </summary>
		[EnumMember(Value = "enabled")]
		Enabled,

		/// <summary>
		/// Enum Disabled for "disabled"
		/// </summary>
		[EnumMember(Value = "disabled")]
		Disabled
	}
}
