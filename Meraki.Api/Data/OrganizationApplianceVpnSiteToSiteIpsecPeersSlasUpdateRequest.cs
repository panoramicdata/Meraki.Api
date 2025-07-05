namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Vpn Site To Site Ipsec Peers Slas Update Request
/// </summary>
[DataContract]
public class OrganizationApplianceVpnSiteToSiteIpsecPeersSlasUpdateRequest
{
	/// <summary>
	/// List of IPsec SLA policies
	/// </summary>
	[DataMember(Name = "items")]
	public List<OrganizationApplianceVpnSiteToSiteIpsecPeersSlasUpdateRequestItem> Items { get; set; } = [];
}
