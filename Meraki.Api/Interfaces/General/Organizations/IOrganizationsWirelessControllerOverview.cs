namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Wireless Controller Overview
/// </summary>
public interface IOrganizationsWirelessControllerOverview
{
	/// <summary>
	/// List the overview information of wireless LAN controllers in an organization and it is updated every minute.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerOverviewByDevice")]
	[Get("/organizations/{organizationId}/wirelessController/overview/byDevice")]
	Task<OrganizationWirelessControllerOverviewByDevice> GetOrganizationWirelessControllerOverviewByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
