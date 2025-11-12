namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Integrations Xdr
/// </summary>
public interface IOrganizationsIntegrationsXdr
{
	/// <summary>
	/// Returns the networks in the organization that have XDR enabled
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationIntegrationsXdrNetworks")]
	[Get("/organizations/{organizationId}/integrations/xdr/networks")]
	Task<List<OrganizationIntegrationsXdrByNetwork>> GetOrganizationIntegrationsXdrNetworksAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Disable XDR on networks
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("disableOrganizationIntegrationsXdrNetworks")]
	[Post("/organizations/{organizationId}/integrations/xdr/networks/disable")]
	Task<OrganizationIntegrationsXdrNetworksDisableResponse> DisableOrganizationIntegrationsXdrNetworksAsync(
		string organizationId,
		[Body] OrganizationIntegrationsXdrNetworksDisableRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Enable XDR on networks
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("enableOrganizationIntegrationsXdrNetworks")]
	[Post("/organizations/{organizationId}/integrations/xdr/networks/enable")]
	Task<OrganizationIntegrationsXdrNetworksEnableResponse> EnableOrganizationIntegrationsXdrNetworksAsync(
		string organizationId,
		[Body] OrganizationIntegrationsXdrNetworksEnableRequest request,
		CancellationToken cancellationToken = default
	);
}
