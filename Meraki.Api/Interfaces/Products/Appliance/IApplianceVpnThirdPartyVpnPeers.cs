namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceVpnThirdPartyVpnPeers
{
	/// <summary>
	/// Return the third party VPN peers for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationApplianceVpnThirdPartyVPNPeers")]
	[Get("/organizations/{organizationId}/appliance/vpn/thirdPartyVPNPeers")]
	Task<ThirdPartyVpnPeers> GetOrganizationApplianceVpnThirdPartyVPNPeersAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return the third party VPN peers for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationApplianceVpnThirdPartyVPNPeers")]
	[Put("/organizations/{organizationId}/appliance/vpn/thirdPartyVPNPeers")]
	Task<ThirdPartyVpnPeers> UpdateOrganizationApplianceVpnThirdPartyVPNPeersAsync(
		string organizationId,
		[Body] ThirdPartyVpnPeers peerList,
		CancellationToken cancellationToken = default);
}
