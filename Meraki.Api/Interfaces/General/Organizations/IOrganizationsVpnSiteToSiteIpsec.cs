namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsVpnSiteToSiteIpsec
{
	/// <summary>
	/// Get the list of available IPsec SLA policies for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationApplianceVpnSiteToSiteIpsecPeersSlas")]
	[Get("/organizations/{organizationId}/appliance/vpn/siteToSite/ipsec/peers/slas")]
	Task<OrganizationApplianceVpnSiteToSiteIpsecPeersSlas> GetOrganizationApplianceVpnSiteToSiteIpsecPeersSlasAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
