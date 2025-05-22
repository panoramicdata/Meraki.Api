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
	Task<List<OrganizationWirelessDevicesChannelUtilization>> GetOrganizationWirelessDevicesChannelUtilizationsAsync(string orgnanizationId, CancellationToken cancellationToken = default);
}
