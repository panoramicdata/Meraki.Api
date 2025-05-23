namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsDevicesSignalQuality
{
	/// <summary>
	/// Get average signal quality for all clients in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesSignalQualityByClient")]
	[Get("/organizations/{organizationId}/wireless/devices/signalQuality/byClient")]
	Task<List<OrganizationWirelessDevicesSignalQualityByClientItem>> GetOrganizationWirelessDevicesSignalQualityByClientAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Get average signal quality for all devices in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesSignalQualityByDevice")]
	[Get("/organizations/{organizationId}/wireless/devices/signalQuality/byDevice")]
	Task<List<OrganizationWirelessDevicesSignalQualityByDeviceItem>> GetOrganizationWirelessDevicesSignalQualityByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Get average signal quality for all networks in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesSignalQualityByNetwork")]
	[Get("/organizations/{organizationId}/wireless/devices/signalQuality/byNetwork")]
	Task<List<OrganizationWirelessDevicesSignalQualityByNetworkItem>> GetOrganizationWirelessDevicesSignalQualityByNetworkAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
