namespace Meraki.Api.Data;

/// <summary>
/// An SNMP trap user
/// </summary>
[DataContract]
public class NetworkSnmpTrapUser
{
	/// <summary>
	/// The name of the SNMP trap user
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The passphrase for the SNMP trap user
	/// </summary>
	[DataMember(Name = "passphrase")]
	public string? Passphrase { get; set; }
}