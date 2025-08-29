namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWirelessRadioSettings
{
	/// <summary>
	/// Return the manually configured radio settings overrides of a device, which take precedence over RF profiles.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cancellationToken"></param>
	[Get("/devices/{serial}/wireless/radio/settings")]
	Task<WirelessRadioSettings> GetDeviceWirelessRadioSettingsAsync(
		string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the radio settings overrides of a device, which take precedence over RF profiles.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="updateNetworkDeviceWirelessRadioSettings">Body for updating radio settings</param>
	/// <param name="cancellationToken"></param>
	[Put("/devices/{serial}/wireless/radio/settings")]
	Task<WirelessRadioSettings> UpdateDeviceWirelessRadioSettingsAsync(
		string serial,
		[Body] WirelessRadioSettings updateNetworkDeviceWirelessRadioSettings,
		CancellationToken cancellationToken = default
		);
}
