using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// TCP or UDP
	/// </summary>
	/// <value>TCP or UDP</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Protocol5
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
