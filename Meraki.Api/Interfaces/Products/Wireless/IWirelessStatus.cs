namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessStatus
{
	/// <summary>
	/// Return the SSID statuses of an access point
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[Get("/devices/{serial}/wireless/status")]
	Task<WirelessStatus> GetDeviceWirelessStatusAsync(
		string serial,
		CancellationToken cancellationToken = default
		);
}
