namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// Provides functionality to retrieve packet loss information for wireless devices within an organization.
/// </summary>
/// <remarks>This interface defines a method for listing the most recent packet loss data for wireless devices.
/// The data is paginated, and the caller can specify the number of entries per page.</remarks>
public interface IWirelessDevicePacketLoss
{
	/// <summary>
	/// List the most recent packet loss information for wireless devices.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization ID</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 100.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[Get("/organizations/{organizationId}/wireless/devices/packetLoss/byDevice")]
	Task<List<WirelessDevicePacketLoss>> GetOrganizationWirelessDevicesPacketLossAsync(
		string organizationId,
		int? perPage = 100,
		string? startingAfter = null,
		string? endingBefore = null,
		CancellationToken cancellationToken = default);
}
