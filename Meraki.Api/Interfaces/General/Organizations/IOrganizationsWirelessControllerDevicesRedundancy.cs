namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Wireless Controller Devices Redundancy
/// </summary>
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

	/// <summary>
	/// List redundancy details of wireless LAN controllers in an organization. The failover count refers to the total failovers system happens from the moment of this device onboarding to Dashboard
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessControllerDevicesRedundancyStatuses")]
	[Get("/organizations/{organizationId}/wirelessController/devices/redundancy/statuses")]
	Task<OrganizationWirelessControllerDevicesRedundancyStatuses> GetOrganizationWirelessControllerDevicesRedundancyStatusesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
