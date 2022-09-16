namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessDeviceEthernetStatuses
{
	/// <summary>
	/// Endpoint to see power status for wireless devices
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization ID</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 100.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	[Get("/organizations/{organizationId}/wireless/devices/ethernet/statuses")]
	Task<List<WirelessDeviceEthernetStatus>> GetOrganizationWirelessDevicesEthernetStatusesAsync(
		string organizationId,
		int? perPage,
		string startingAfter = null!,
		string endingBefore = null!,
		CancellationToken cancellationToken = default);

	// Used by GetOrganizationWirelessDevicesEthernetStatusesAllAsync
	[Get("/organizations/{organizationId}/wireless/devices/ethernet/statuses")]
	internal Task<ApiResponse<List<WirelessDeviceEthernetStatus>>> GetOrganizationWirelessDevicesEthernetStatusesApiResponseAsync(
		string organizationId,
		string? startingAfter = null,
		CancellationToken cancellationToken = default);
}
