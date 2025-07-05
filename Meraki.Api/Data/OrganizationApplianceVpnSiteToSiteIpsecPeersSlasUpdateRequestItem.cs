namespace Meraki.Api.Data;

/// <summary>
/// IPsec SLA policy
/// </summary>
[DataContract]
public class OrganizationApplianceVpnSiteToSiteIpsecPeersSlasUpdateRequestItem
{
	/// <summary>
	/// SLA policy name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Endpoint for testing SLA
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uri")]
	public string? Uri { get; set; }
}