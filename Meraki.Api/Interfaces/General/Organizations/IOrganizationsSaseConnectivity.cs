namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSaseConnectivity
{
	/// <summary>
	/// List of MX networks or templates that can be enrolled into Secure Access
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSaseConnectivityEnrollableNetworks")]
	[Get("/organizations/{organizationId}/sase/connectivity/enrollableNetworks")]
	Task<OrganizationsSaseConnectivityEnrollableNetworkResponse> GetOrganizationSaseConnectivityEnrollableNetworksAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
