using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The signature type for the custom pie chart item. Can be one of 'host', 'port' or 'ipRange'.
	/// </summary>
	/// <value>The signature type for the custom pie chart item. Can be one of 'host', 'port' or 'ipRange'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Type8
	{

		/// <summary>
		/// Enum Host for "host"
		/// </summary>
		[EnumMember(Value = "host")]
		Host,

		/// <summary>
		/// Enum Port for "port"
		/// </summary>
		[EnumMember(Value = "port")]
		Port,

		/// <summary>
		/// Enum IpRange for "ipRange"
		/// </summary>
		[EnumMember(Value = "ipRange")]
		IpRange
	}
}
