namespace Meraki.Api.Data;

/// <summary>
/// V3 mode
/// </summary>
[DataContract]
public class NetworkSnmpTrapV3Request
{
	/// <summary>
	/// An array of SNMP trap users. Any previous SNMP trap user configuration will be overwritten by values submitted through this parameter
	/// </summary>
	[DataMember(Name = "users")]
	public List<NetworkSnmpTrapUser>? Users { get; set; }
}
