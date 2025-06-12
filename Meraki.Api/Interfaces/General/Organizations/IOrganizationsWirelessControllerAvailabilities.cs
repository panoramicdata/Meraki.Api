namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessControllerAvailabilities
{
	/// <summary>
	/// List connectivity data of wireless LAN controllers in an organization. If it is HA setup, then only returns active WLC data start from switchover
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerAvailabilitiesChangeHistory")]
	[Get("/organizations/{organizationId}/wirelessController/availabilities/changeHistory")]
	Task<OrganizationWirelessControllerAvailabilitiesChangeHistory> GetOrganizationWirelessControllerAvailabilitiesChangeHistoryAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
