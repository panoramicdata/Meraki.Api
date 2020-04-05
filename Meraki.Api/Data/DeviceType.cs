using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Defines deviceType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DeviceType
	{

		/// <summary>
		/// Enum Combined for "combined"
		/// </summary>
		[EnumMember(Value = "combined")]
		Combined,

		/// <summary>
		/// Enum Wireless for "wireless"
		/// </summary>
		[EnumMember(Value = "wireless")]
		Wireless,

		/// <summary>
		/// Enum Switch for "switch"
		/// </summary>
		[EnumMember(Value = "switch")]
		Switch,

		/// <summary>
		/// Enum Appliance for "appliance"
		/// </summary>
		[EnumMember(Value = "appliance")]
		Appliance
	}
}
