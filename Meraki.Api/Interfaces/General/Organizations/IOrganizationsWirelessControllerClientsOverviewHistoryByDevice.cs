namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessControllerClientsOverviewHistoryByDevice
{
	/// <summary>
	/// List wireless client counts of wireless LAN controllers over time in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerClientsOverviewHistoryByDeviceByInterval")]
	[Get("/organizations/{organizationId}/wirelessController/clients/overview/history/byDevice/byInterval")]
	Task<OrganizationWirelessControllerClientsOverviewHistoryByDeviceByInterval> GetOrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
