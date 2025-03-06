namespace Meraki.Api.Data;

/// <summary>
/// The type for the DHCP option. One of: 'text', 'ip', 'hex' or 'integer'
/// </summary>
/// <value>The type for the DHCP option. One of: 'text', 'ip', 'hex' or 'integer'</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum DhcpOptionType
{
#pragma warning disable CA1720 // Identifier contains type name
	/// <summary>
	/// Enum Text for "text"
	/// </summary>
	[EnumMember(Value = "text")]
	Text,

	/// <summary>
	/// Enum Ip for "ip"
	/// </summary>
	[EnumMember(Value = "ip")]
	Ip,

	/// <summary>
	/// Enum Hex for "hex"
	/// </summary>
	[EnumMember(Value = "hex")]
	Hex,

	/// <summary>
	/// Enum Integer for "integer"
	/// </summary>
	[EnumMember(Value = "integer")]
	Integer,

	/// <summary>
	/// Enum BootOptionsEnabled for "boot_options_enabled" - undocumented, seen 2025-03-04
	/// </summary>
	[EnumMember(Value = "boot_options_enabled")]
	BootOptionsEnabled,

	/// <summary>
	/// Enum NextServer for "boot_options_enabled" - undocumented, seen 2025-03-06
	/// </summary>
	[EnumMember(Value = "next_server")]
	NextServer

#pragma warning restore CA1720 // Identifier contains type name
}
