using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// The type of protocol (must be 'tcp', 'udp', or 'any').
/// </summary>
/// <value>The type of protocol (must be 'tcp', 'udp', or 'any').</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum TcpUdpAnyProtocol
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
	/// Enum Any for "any"
	/// </summary>
	[EnumMember(Value = "any")]
	Any
}
