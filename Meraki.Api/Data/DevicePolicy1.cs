using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The policy to apply to the specified client. Can be 'Whitelisted', 'Blocked' or 'Normal'. Required.
	/// </summary>
	/// <value>The policy to apply to the specified client. Can be 'Whitelisted', 'Blocked' or 'Normal'. Required.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DevicePolicy1
	{
		/// <summary>
		/// Enum Whitelisted for "Whitelisted"
		/// </summary>
		[EnumMember(Value = "Whitelisted")]
		Whitelisted,

		/// <summary>
		/// Enum Blocked for "Blocked"
		/// </summary>
		[EnumMember(Value = "Blocked")]
		Blocked,

		/// <summary>
		/// Enum Normal for "Normal"
		/// </summary>
		[EnumMember(Value = "Normal")]
		Normal
	}
}
