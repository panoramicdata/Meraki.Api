namespace Meraki.Api.Data;

/// <summary>
/// Acl Policy
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AclPolicy
{
	/// <summary>
	/// Allow
	/// </summary>
	[EnumMember(Value = "allow")]
	Allow,

	/// <summary>
	/// Deny
	/// </summary>
	[EnumMember(Value = "deny")]
	Deny
}