using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Per switch exception (combined, redundant, useNetworkSetting)
	/// </summary>
	/// <value>Per switch exception (combined, redundant, useNetworkSetting)</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PowerType
	{
		/// <summary>
		/// Enum Combined for "combined"
		/// </summary>
		[EnumMember(Value = "combined")]
		Combined,

		/// <summary>
		/// Enum Redundant for "redundant"
		/// </summary>
		[EnumMember(Value = "redundant")]
		Redundant,

		/// <summary>
		/// Enum UseNetworkSetting for "useNetworkSetting"
		/// </summary>
		[EnumMember(Value = "useNetworkSetting")]
		UseNetworkSetting
	}
}
