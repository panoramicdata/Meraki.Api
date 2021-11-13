namespace Meraki.Api.Interfaces
{
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
		[Get("/devices/{serial}")]
		Task<Device> GetDeviceAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the attributes of a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="device">Body for updating a device</param>
		[Put("/devices/{serial}")]
		Task<Device> UpdateDeviceAsync(
			[AliasAs("serial")] string serial,
			[Body] Device device,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Blink the LEDs on a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="blinkLeds">Body for blinking device leds</param>
		[Post("/devices/{serial}/blinkLeds")]
		Task<BlinkLeds> BlinkDeviceLedsAsync(
			[AliasAs("serial")] string serial,
			[Body] BlinkLeds blinkLeds,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Reboot a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Post("/devices/{serial}/reboot")]
		Task<UpdateOnboardingStatusResponse> RebootDeviceAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);
	}
}
