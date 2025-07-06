namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessControllerDevicesSystemUtilizationHistory
{
	/// <summary>
	/// List cpu utilization data of wireless LAN controllers in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerDevicesSystemUtilizationHistoryByInterval")]
	[Get("/organizations/{organizationId}/wirelessController/devices/system/utilization/history/byInterval")]
	Task<OrganizationWirelessControllerDevicesSystemUtilizationHistoryByInterval> GetOrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
