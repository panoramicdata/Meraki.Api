namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Devices Power
/// </summary>
public interface IOrganizationsDevicesPower
{
	/// <summary>
	/// Return a record of power mode changes for wireless devices in the organization. For each device, it provides a series of events with timestamps indicating when a power mode change occurred and the new mode. The events are ordered by timestamp.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesPowerModeHistory")]
	[Get("/organizations/{organizationId}/wireless/devices/power/mode/history")]
	Task<OrganizationWirelessDevicesPowerModeHistory> GetOrganizationWirelessDevicesPowerModeHistory(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
