namespace Meraki.Api.Data;

/// <summary>
/// SnmpUser
/// </summary>
[DataContract]
public class SnmpUser
{
	/// <summary>
	/// The username for the SNMP user. Required.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "username")]
	public string Username { get; set; } = string.Empty;

	/// <summary>
	/// The passphrase for the SNMP user. Required.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "passphrase")]
	public string Passphrase { get; set; } = string.Empty;
}
