namespace Meraki.Api.Data;

/// <summary>
/// Configuration details for SNMP v3
/// </summary>
[DataContract]
public class NetworkSnmpTrapV3Response
{
	/// <summary>
	/// An array of users for SNMP v3
	/// </summary>
	[DataMember(Name = "users")]
	public List<NetworkSnmpTrapV3ResponseUser>? Users { get; set; }

}
