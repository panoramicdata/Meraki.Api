namespace Meraki.Api.Data;

/// <summary>
/// A User for SNMP v3
/// </summary>
[DataContract]
public class NetworkSnmpTrapV3ResponseUser
{
	/// <summary>
	/// Name of the user
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}