namespace Meraki.Api.Data;

/// <summary>
/// Configuration details for SNMP v2 
/// </summary>
[DataContract]
public class OrganizationSnmpTrapByNetworkV2
{
	/// <summary>
	/// Community string used for SNMP v1/v2c
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "community")]
	public string Community { get; set; } = string.Empty;
}