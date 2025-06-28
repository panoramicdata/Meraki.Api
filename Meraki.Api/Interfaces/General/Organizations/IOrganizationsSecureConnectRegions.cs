namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSecureConnectRegions
{
	/// <summary>
	/// List deployed cloud hubs and regions in this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectRegions")]
	[Get("/organizations/{organizationId}/secureConnect/regions")]
	Task<OrganizationSecureConnectRegions> GetOrganizationSecureConnectRegionsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
