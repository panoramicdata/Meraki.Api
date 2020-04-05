using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// 'allow' or 'deny' traffic specified by this rule.
	/// </summary>
	/// <value>'allow' or 'deny' traffic specified by this rule.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Policy7
	{

		/// <summary>
		/// Enum Allow for "allow"
		/// </summary>
		[EnumMember(Value = "allow")]
		Allow,

		/// <summary>
		/// Enum Deny for "deny"
		/// </summary>
		[EnumMember(Value = "deny")]
		Deny
	}
}
