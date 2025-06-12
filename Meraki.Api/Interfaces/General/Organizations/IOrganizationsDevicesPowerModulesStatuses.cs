namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsDevicesPowerModulesStatuses
{
	/// <summary>
	/// List the most recent status information for power modules in rackmount MX and MS devices that support them. The data returned by this endpoint is updated every 5 minutes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationDevicesPowerModulesStatusesByDevice")]
	[Get("/organizations/{organizationId}/devices/powerModules/statuses/byDevice")]
	Task<List<OrganizationDevicesPowerModuleStatus>> GetOrganizationDevicesPowerModuleStatusesByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
