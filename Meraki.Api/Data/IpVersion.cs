using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// IP address version (must be 'any', 'ipv4' or 'ipv6'). Applicable only if network supports IPv6. Default value is 'ipv4'.
	/// </summary>
	/// <value>IP address version (must be 'any', 'ipv4' or 'ipv6'). Applicable only if network supports IPv6. Default value is 'ipv4'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IpVersion
	{

		/// <summary>
		/// Enum Any for "any"
		/// </summary>
		[EnumMember(Value = "any")]
		Any,

		/// <summary>
		/// Enum Ipv4 for "ipv4"
		/// </summary>
		[EnumMember(Value = "ipv4")]
		Ipv4,

		/// <summary>
		/// Enum Ipv6 for "ipv6"
		/// </summary>
		[EnumMember(Value = "ipv6")]
		Ipv6
	}
}
