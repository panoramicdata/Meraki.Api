namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Vpn Site To Site Ipsec
/// </summary>
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

	/// <summary>
	/// Update the IPsec SLA policies for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationApplianceVpnSiteToSiteIpsecPeersSlas")]
	[Put("/organizations/{organizationId}/appliance/vpn/siteToSite/ipsec/peers/slas")]
	Task<OrganizationApplianceVpnSiteToSiteIpsecPeersSlas> UpdateOrganizationApplianceVpnSiteToSiteIpsecPeersSlasAsync(
		string organizationId,
		[Body] OrganizationApplianceVpnSiteToSiteIpsecPeersSlasUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
