namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWirelessRadioSettings
{
	/// <summary>
	/// Return the radio settings of a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[Get("/devices/{serial}/wireless/radio/settings")]
	Task<RadioGhzSettings> GetNetworkDeviceWirelessRadioSettingsAsync(
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the radio settings of a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="updateNetworkDeviceWirelessRadioSettings">Body for updating radio settings</param>
	[Put("/devices/{serial}/wireless/radio/settings")]
	Task<WirelessRadioSettingsUpdateRequest> UpdateNetworkDeviceWirelessRadioSettingsAsync(
		[AliasAs("serial")] string serial,
		[Body] WirelessRadioSettingsUpdateRequest updateNetworkDeviceWirelessRadioSettings,
		CancellationToken cancellationToken = default
		);
}
