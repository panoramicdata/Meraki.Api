using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// 'Deny' traffic specified by this rule
	/// </summary>
	/// <value>'Deny' traffic specified by this rule</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Policy5
	{

		/// <summary>
		/// Enum Deny for "deny"
		/// </summary>
		[EnumMember(Value = "deny")]
		Deny
	}
}
