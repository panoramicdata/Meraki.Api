namespace Meraki.Api.Interfaces.General.Organizations;
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
}
