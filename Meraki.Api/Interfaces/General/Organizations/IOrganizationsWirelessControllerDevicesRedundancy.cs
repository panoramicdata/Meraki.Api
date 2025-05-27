namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessControllerDevicesRedundancy
{
	/// <summary>
	/// List the failover events of wireless LAN controllers in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerDevicesRedundancyFailoverHistory")]
	[Get("/organizations/{organizationId}/wirelessController/devices/redundancy/failover/history")]
	Task<List<OrganizationWirelessControllerDevicesRedundancyFailoverHistory>> GetOrganizationWirelessControllerDevicesRedundancyFailoverHistoryAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
