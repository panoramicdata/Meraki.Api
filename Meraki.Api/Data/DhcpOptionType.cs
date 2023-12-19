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
	Integer
#pragma warning restore CA1720 // Identifier contains type name
}
