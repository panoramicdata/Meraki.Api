using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Enable or disable the interface (only for MX devices). Valid values are 'enabled', 'disabled', and 'not configured'.
	/// </summary>
	/// <value>Enable or disable the interface (only for MX devices). Valid values are 'enabled', 'disabled', and 'not configured'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum WanEnabledStatus
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
		Disabled,

		/// <summary>
		/// Enum Notconfigured for "not configured"
		/// </summary>
		[EnumMember(Value = "not configured")]
		Notconfigured
	}
}
