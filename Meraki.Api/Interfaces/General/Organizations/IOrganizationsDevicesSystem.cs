namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsDevicesSystem
{
	/// <summary>
	/// Return the CPU Load history for a list of wireless devices in the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesSystemCpuLoadHistory")]
	[Get("/organizations/{organizationId}/wireless/devices/system/cpu/load/history")]
	Task<OrganizationWirelessDevicesSystemCpuLoadHistory> GetOrganizationWirelessDevicesSystemCpuLoadHistoryAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
