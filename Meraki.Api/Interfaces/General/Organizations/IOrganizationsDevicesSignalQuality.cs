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
}
