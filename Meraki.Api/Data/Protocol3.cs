using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// 'tcp' or 'udp'
	/// </summary>
	/// <value>'tcp' or 'udp'</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Protocol3
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
