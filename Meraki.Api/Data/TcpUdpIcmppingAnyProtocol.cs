using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Either of the following: 'tcp', 'udp', 'icmp-ping' or 'any'
/// </summary>
/// <value>Either of the following: 'tcp', 'udp', 'icmp-ping' or 'any'</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum TcpUdpIcmppingAnyProtocol
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
	/// Enum Icmpping for "icmp-ping"
	/// </summary>
	[EnumMember(Value = "icmp-ping")]
	Icmpping,

	/// <summary>
	/// Enum Any for "any"
	/// </summary>
	[EnumMember(Value = "any")]
	Any
}
