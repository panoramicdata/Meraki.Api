using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// 'tcp' or 'udp'
	/// </summary>
	/// <value>'tcp' or 'udp'</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TcpUdpProtocol
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
		Udp
	}
}
