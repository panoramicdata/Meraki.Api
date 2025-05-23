namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsWirelessDevicesPacketLoss
{
	/// <summary>
	/// Get average packet loss for the given timespan for all clients in the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesPacketLossByClient")]
	[Get("/organizations/{organizationId}/wireless/devices/packetLoss/byClient")]
	Task<List<OrganizationWirelessDevicesPacketLossByClientItem>> GetOrganizationWirelessDevicesPacketLossByClientAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get average packet loss for the given timespan for all devices in the organization. Does not include device's own traffic.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesPacketLossByDevice")]
	[Get("/organizations/{organizationId}/wireless/devices/packetLoss/byDevice")]
	Task<List<OrganizationWirelessDevicesPacketLossByDeviceItem>> GetOrganizationWirelessDevicesPacketLossByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
