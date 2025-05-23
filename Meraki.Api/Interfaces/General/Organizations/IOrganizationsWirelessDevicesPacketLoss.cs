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
	Task<List<OrganizationWirelessDevicesPacketLossItem>> GetOrganizationWirelessDevicesPacketLossByClientAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
