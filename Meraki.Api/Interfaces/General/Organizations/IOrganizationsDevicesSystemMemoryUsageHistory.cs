namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsDevicesSystemMemoryUsageHistory
{
	/// <summary>
	/// Return the memory utilization history in kB for devices in the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationDevicesSystemMemoryUsageHistoryByInterval")]
	[Get("/organizations/{organizationId}/devices/system/memory/usage/history/byInterval")]
	Task<OrganizationDevicesSystemMemoryUsageHistoryByInterval> GetOrganizationDevicesSystemMemoryUsageHistoryByIntervalAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
