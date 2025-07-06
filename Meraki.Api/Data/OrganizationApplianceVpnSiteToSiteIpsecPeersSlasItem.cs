namespace Meraki.Api.Data;

/// <summary>
/// IPSec SLA policy
/// </summary>
[DataContract]
public class OrganizationApplianceVpnSiteToSiteIpsecPeersSlasItem
{
	/// <summary>
	/// SLA policy ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// SLA policy name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Endpoint for testing SLA
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uri")]
	public string Uri { get; set; } = string.Empty;

	/// <summary>
	/// IPsec configuration data
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipsec")]
	public OrganizationApplianceVpnSiteToSiteIpsecPeersSlasItemIpsec Ipsec { get; set; } = new();
}
