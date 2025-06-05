namespace Meraki.Api.Data;

/// <summary>
/// User for SNMP v3 
/// </summary>
[DataContract]
public class OrganizationSnmpTrapByNetworkV3User
{
	/// <summary>
	/// Name of the user
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}