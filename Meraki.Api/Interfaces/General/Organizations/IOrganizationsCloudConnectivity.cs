namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Cloud Connectivity
/// </summary>
public interface IOrganizationsCloudConnectivity
{
	/// <summary>
	/// List of source/destination traffic rules
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationCloudConnectivityRequirements")]
	[Get("/organizations/{organizationId}/cloud/connectivity/requirements")]
	Task<List<OrganizationCloudConnectivityRequirement>> GetCloudConnectivityRequirementsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
