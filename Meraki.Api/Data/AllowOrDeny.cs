using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// 'allow' or 'deny' traffic specified by this rule
/// </summary>
/// <value>'allow' or 'deny' traffic specified by this rule</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum AllowOrDeny
{
	/// <summary>
	/// Enum Allow for "allow"
	/// </summary>
	[EnumMember(Value = "allow")]
	Allow = 1,

	/// <summary>
	/// Enum Deny for "deny"
	/// </summary>
	[EnumMember(Value = "deny")]
	Deny
}
