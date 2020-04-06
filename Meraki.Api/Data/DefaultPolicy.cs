using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// 'allow' or 'block' new DHCP servers. Default value is 'allow'.
	/// </summary>
	/// <value>'allow' or 'block' new DHCP servers. Default value is 'allow'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DefaultPolicy
	{
		/// <summary>
		/// Enum Allow for "allow"
		/// </summary>
		[EnumMember(Value = "allow")]
		Allow,

		/// <summary>
		/// Enum Block for "block"
		/// </summary>
		[EnumMember(Value = "block")]
		Block
	}
}
