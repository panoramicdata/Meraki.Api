namespace Meraki.Api.Data;

/// <summary>
/// SNMP trap receiver details 
/// </summary>
[DataContract]
public class OrganizationSnmpTrapByNetworkReceiver
{
	/// <summary>
	/// IP address of the SNMP trap receiver
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Port number of the SNMP trap receiver
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public string Port { get; set; } = string.Empty;
}