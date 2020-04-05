using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The type of protocol (must be 'tcp', 'udp', 'icmp' or 'any')
	/// </summary>
	/// <value>The type of protocol (must be 'tcp', 'udp', 'icmp' or 'any')</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Protocol
	{

		/// <summary>
		/// Enum Tcp for "tcp"
		/// </summary>
		[EnumMember(Value = "tcp")]
		Tcp,

		/// <summary>
		/// Enum Udp for "udp"
		/// </summary>
		[EnumMember(Value = "udp")]
		Udp,

		/// <summary>
		/// Enum Icmp for "icmp"
		/// </summary>
		[EnumMember(Value = "icmp")]
		Icmp,

		/// <summary>
		/// Enum Any for "any"
		/// </summary>
		[EnumMember(Value = "any")]
		Any
	}
}
