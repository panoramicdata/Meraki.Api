namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessDevicesLatency
{
	/// <summary>
	/// Get latency summaries for all wireless devices in an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesLatencyByClient")]
	[Get("/organizations/{organizationId}/wireless/devices/latency/byClient")]
	Task<List<OrganizationWirelessDevicesLatencyByClientItem>> GetOrganizationWirelessDevicesLatenciesAsync(string organizationId, CancellationToken cancellationToken = default);
}
