using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The protocol of the incoming packet. Can be one of \"ANY\", \"TCP\" or \"UDP\". Default value is \"ANY\".
	/// </summary>
	/// <value>The protocol of the incoming packet. Can be one of \"ANY\", \"TCP\" or \"UDP\". Default value is \"ANY\".</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Protocol9
	{

		/// <summary>
		/// Enum ANY for "ANY"
		/// </summary>
		[EnumMember(Value = "ANY")]
		ANY,

		/// <summary>
		/// Enum TCP for "TCP"
		/// </summary>
		[EnumMember(Value = "TCP")]
		TCP,

		/// <summary>
		/// Enum UDP for "UDP"
		/// </summary>
		[EnumMember(Value = "UDP")]
		UDP
	}
}
