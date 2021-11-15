namespace Meraki.Api.Data;

/// <summary>
/// 'allow' or 'block' new DHCP servers. Default value is 'allow'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DefaultPolicy
{
	/// <summary>
	/// Enum Allow for "allow"
	/// </summary>
	[EnumMember(Value = "allow")]
	Allow = 1,

	/// <summary>
	/// Enum Block for "block"
	/// </summary>
	[EnumMember(Value = "block")]
	Block
}
