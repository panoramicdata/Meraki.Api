using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Type of the L7 Rule. Must be 'application', 'applicationCategory', 'host', 'port' or 'ipRange'
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Layer7FirewallRuleType
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
