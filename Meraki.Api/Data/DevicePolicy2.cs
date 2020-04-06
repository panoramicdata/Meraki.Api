using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The policy to apply to the specified client. Can be 'Whitelisted', 'Blocked', 'Normal' or 'Group policy'. Required.
	/// </summary>
	/// <value>The policy to apply to the specified client. Can be 'Whitelisted', 'Blocked', 'Normal' or 'Group policy'. Required.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DevicePolicy2
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
		Normal,

		/// <summary>
		/// Enum Grouppolicy for "Group policy"
		/// </summary>
		[EnumMember(Value = "Group policy")]
		Grouppolicy
	}
}
