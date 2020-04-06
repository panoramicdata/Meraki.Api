using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// 'Deny' traffic specified by this rule
	/// </summary>
	/// <value>'Deny' traffic specified by this rule</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DenyOnlyPolicy
	{
		/// <summary>
		/// Enum Deny for "deny"
		/// </summary>
		[EnumMember(Value = "deny")]
		Deny
	}
}
