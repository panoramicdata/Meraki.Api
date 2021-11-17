namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraVideo
{

	/// <summary>
	/// Returns video settings for the given camera
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial id</param>
	[ApiOperationId("getDeviceCameraVideoSettings")]
	[Get("/devices/{serial}/camera/video/settings")]
	Task<CameraVideo> GetDeviceCameraVideoSettingsAsync(
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Updates video settings for the given camera
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial id</param>
	/// <param name="cameraVideoSetting">Body for updating device camera video setting</param>
	[ApiOperationId("updateDeviceCameraVideoSettings")]
	[Put("/devices/{serial}/camera/video/settings")]
	Task<CameraVideo> UpdateDeviceCameraVideoSettingsAsync(
		[AliasAs("serial")] string serial,
		[Body] CameraVideo cameraVideoSetting,
		CancellationToken cancellationToken = default);

}
