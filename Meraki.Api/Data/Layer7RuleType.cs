using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Type of the L7 rule. One of: 'application', 'applicationCategory', 'host', 'port', 'ipRange'
	/// </summary>
	/// <value>Type of the L7 rule. One of: 'application', 'applicationCategory', 'host', 'port', 'ipRange'</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Layer7RuleType
	{

		/// <summary>
		/// Enum Application for "application"
		/// </summary>
		[EnumMember(Value = "application")]
		Application,

		/// <summary>
		/// Enum ApplicationCategory for "applicationCategory"
		/// </summary>
		[EnumMember(Value = "applicationCategory")]
		ApplicationCategory,

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
