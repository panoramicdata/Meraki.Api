namespace Meraki.Api.Interfaces.Products.Camera;

/// <summary>
/// I Camera Custom Analytics
/// </summary>
public interface ICameraCustomAnalytics
{
	/// <summary>
	/// Return custom analytics settings for a camera
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cancellationToken"></param>
	[Get("/devices/{serial}/camera/customAnalytics")]
	Task<List<CameraCustomAnalytics>> GetDeviceCameraCustomAnalyticsAsync(
		string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update custom analytics settings for a camera
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cameraCustomAnalyticsUpdate">Body for updating camera custom analytics</param>
	/// <param name="cancellationToken"></param>
	[Put("/devices/{serial}/camera/customAnalytics")]
	Task<List<CameraCustomAnalytics>> UpdateDeviceCameraCustomAnalyticsAsync(
		string serial,
		[Body] CameraCustomAnalyticsUpdate cameraCustomAnalyticsUpdate,
		CancellationToken cancellationToken = default
		);
}
