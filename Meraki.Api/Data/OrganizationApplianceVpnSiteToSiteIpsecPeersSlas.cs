namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Vpn Site To Site Ipsec Peers Slas
/// </summary>
[DataContract]
public class OrganizationApplianceVpnSiteToSiteIpsecPeersSlas
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationApplianceVpnSiteToSiteIpsecPeersSlasMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of the IPSec SLA policies for an organization
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationApplianceVpnSiteToSiteIpsecPeersSlasItem> Items { get; set; } = [];
}
