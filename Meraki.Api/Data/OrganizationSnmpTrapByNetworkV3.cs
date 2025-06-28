namespace Meraki.Api.Data;

/// <summary>
/// Configuration details for SNMP v3
/// </summary>
[DataContract]
public class OrganizationSnmpTrapByNetworkV3
{
	/// <summary>
	/// An array of users for SNMP v3
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "users")]
	public List<OrganizationSnmpTrapByNetworkV3User> Users { get; set; } = [];
}
