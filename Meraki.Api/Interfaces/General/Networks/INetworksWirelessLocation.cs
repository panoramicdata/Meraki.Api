namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// I Networks Wireless Location
/// </summary>
public interface INetworksWirelessLocation
{
	/// <summary>
	/// Change scanning API settings
	/// </summary>
	/// <param name="networkId"></param>
	/// <param name="locationScanningUpdateRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateNetworkWirelessLocationScanning")]
	[Put("/networks/{networkId}/wireless/location/scanning")]
	Task<LocationScanning> UpdateNetworkWirelessLocationScanningAsync(
		string networkId,
		[Body] LocationScanningUpdateRequest locationScanningUpdateRequest,
		CancellationToken cancellationToken = default);
}
