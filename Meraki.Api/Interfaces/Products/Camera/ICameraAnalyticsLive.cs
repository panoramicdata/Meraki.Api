namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraAnalyticsLive
{
	/// <summary>
	/// Returns live state from camera of analytics zones
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[Get("/devices/{serial}/camera/analytics/live")]
	Task<CameraLive> GetDeviceCameraAnalyticsLiveAsync(
		string serial,
		CancellationToken cancellationToken = default
		);
}
