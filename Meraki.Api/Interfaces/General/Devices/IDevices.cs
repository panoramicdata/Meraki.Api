namespace Meraki.Api.Interfaces.General.Devices;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IDevices
{
	/// <summary>
	/// Return a single device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDevice")]
	[Get("/devices/{serial}")]
	Task<Device> GetDeviceAsync(
		string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the attributes of a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="device">Body for updating a device</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateDevice")]
	[Put("/devices/{serial}")]
	Task<Device> UpdateDeviceAsync(
		string serial,
		[Body] Device device,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Blink the LEDs on a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="blinkLeds">Body for blinking device leds</param>
	/// <param name="cancellationToken"></param>
	[Obsolete("Deprecated in Meraki API v1.53 in favour of General.LiveTools.CreateDeviceLiveToolsLedsBlink")]
	[ApiOperationId("blinkDeviceLeds")]
	[Post("/devices/{serial}/blinkLeds")]
	Task<BlinkLeds> BlinkDeviceLedsAsync(
		string serial,
		[Body] BlinkLeds blinkLeds,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Reboot a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("rebootDevice")]
	[Post("/devices/{serial}/reboot")]
	Task<ActionResponse> RebootDeviceAsync(
		string serial,
		CancellationToken cancellationToken = default);
}
