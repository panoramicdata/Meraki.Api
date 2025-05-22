namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsWirelessDevicesChannelUtilization
{
	/// <summary>
	/// Get average channel utilization for all bands in a network, split by AP
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="orgnanizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesChannelUtilizationByDevice")]
	[Get("/organizations/{organizationId}/wireless/devices/channelUtilization/byDevice")]
	Task<List<OrganizationWirelessDevicesChannelUtilizationByDeviceItem>> GetOrganizationWirelessDevicesChannelUtilizationsByDeviceAsync(string orgnanizationId, CancellationToken cancellationToken = default);

	/// <summary>
	/// Get average channel utilization across all bands for all networks in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="orgnanizationId"></param>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesChannelUtilizationByNetwork")]
	[Get("/organizations/{organizationId}/wireless/devices/channelUtilization/byNetwork")]
	Task<List<OrganizationWirelessDevicesChannelUtilizationByNetworkItem>> GetOrganizationWirelessDevicesChannelUtilizationsByNetworkAsync(string orgnanizationId, string networkId, CancellationToken cancellationToken = default);
}
