namespace Meraki.Api.Data;

/// <summary>
/// The SNMP version 3 privacy mode. Can be either 'DES' or 'AES128'.
/// </summary>
/// <value>The SNMP version 3 privacy mode. Can be either 'DES' or 'AES128'.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum SnmpV3PrivMode
{
	/// <summary>
	/// Enum DES for "DES"
	/// </summary>
	[EnumMember(Value = "DES")]
	Des,

	/// <summary>
	/// Enum AES128 for "AES128"
	/// </summary>
	[EnumMember(Value = "AES128")]
	Aes128
}
