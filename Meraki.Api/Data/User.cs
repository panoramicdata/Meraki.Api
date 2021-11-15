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
	/// <value>The username for the SNMP user. Required.</value>
	[DataMember(Name = "username")]
	public string Username { get; set; } = null!;
	/// <summary>
	/// The passphrase for the SNMP user. Required.
	/// </summary>
	/// <value>The passphrase for the SNMP user. Required.</value>
	[DataMember(Name = "passphrase")]
	public string Passphrase { get; set; } = null!;
}
