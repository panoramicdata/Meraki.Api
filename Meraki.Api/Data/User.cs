namespace Meraki.Api.Data;

/// <summary>
/// User
/// </summary>
[DataContract]
public class User
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
