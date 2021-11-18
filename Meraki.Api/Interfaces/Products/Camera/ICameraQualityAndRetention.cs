namespace Meraki.Api.Interfaces.Products.Camera
{
	public interface ICameraQualityAndRetention
	{

		/// <summary>
		/// Returns quality and retention settings for the given camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[ApiOperationId("getDeviceCameraQualityAndRetention")]
		[Get("/devices/{serial}/camera/qualityAndRetention")]
		Task<CameraQualityAndRetention> GetDeviceCameraQualityAndRetentionAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update quality and retention settings for the given camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="cameraQualityAndRetention">Body for updating camera quality and retention settings</param>
		[ApiOperationId("updateDeviceCameraQualityAndRetention")]
		[Put("/devices/{serial}/camera/qualityAndRetention")]
		Task<CameraQualityAndRetention> UpdateDeviceCameraQualityAndRetentionAsync(
			[AliasAs("serial")] string serial,
			[Body] CameraQualityAndRetention cameraQualityAndRetention,
			CancellationToken cancellationToken = default);

	}
}
