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

	/// <summary>
	/// Update the IPsec SLA policies for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationApplianceVpnSiteToSiteIpsecPeersSlas")]
	[Put("/organizations/{organizationId}/appliance/vpn/siteToSite/ipsec/peers/slas")]
	Task<OrganizationApplianceVpnSiteToSiteIpsecPeersSlas> UpdateOrganizationApplianceVpnSiteToSiteIpsecPeersSlasAsync(
		[Body] OrganizationApplianceVpnSiteToSiteIpsecPeersSlasUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
