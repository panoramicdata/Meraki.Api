namespace Meraki.Api.Interfaces.General.LiveTools;

/// <summary>
/// I Live Tools Leds
/// </summary>
public interface ILiveToolsLeds
{
	/// <summary>
	/// Enqueue a job to blink LEDs on a device. This endpoint has a rate limit of one request every 10 seconds.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsLedsBlink">Body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createDeviceLiveToolsLedsBlink")]
	[Post("/devices/{serial}/liveTools/leds/blink")]
	Task<LiveToolsLedsBlink> CreateDeviceLiveToolsLedsBlinkAsync(
		string serial,
		[Body] LiveToolsLedsBlinkRequest createDeviceLiveToolsLedsBlink,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a blink LEDs job
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="ledsBlinkId">Leds blink ID</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceLiveToolsLedsBlink")]
	[Get("/devices/{serial}/liveTools/leds/blink/{ledsBlinkId}")]
	Task<LiveToolsLedsBlink> GetDeviceLiveToolsLedsBlinkAsync(
		string serial,
		string ledsBlinkId,
		CancellationToken cancellationToken = default);
}
