using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ICameras
	{
		/// <summary>
		/// generateNetworkCameraSnapshot
		/// </summary>
		/// <remarks>
		/// Generate a snapshot of what the camera sees at the specified time and return a link to that image.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="generateNetworkCameraSnapshot"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Post("/devices/{serial}/camera/generateSnapshot")]
		Task<CameraSnapshot> GetSnapshotAsync(
			[AliasAs("serial")]string serial,
			[Body]CameraSnapshotRequest generateNetworkCameraSnapshot,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getDeviceCameraQualityAndRetentionSettings
		/// </summary>
		/// <remarks>
		/// Returns quality and retention settings for the given camera
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/camera/qualityAndRetentionSettings")]
		Task<CameraQualityAndRetentionSettings> GetQualityAndRetentionSettingsAsync(
			[AliasAs("serial")]string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkCameraSchedules
		/// </summary>
		/// <remarks>
		/// Returns a list of all camera recording schedules.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/camera/schedules")]
		Task<CameraSchedule> GetSchedulesAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkCameraVideoLink
		/// </summary>
		/// <remarks>
		/// Returns video link to the specified camera. If a timestamp is supplied, it links to that timestamp.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="serial"></param>
		/// <param name="timestamp">[optional] The video link will start at this timestamp. The timestamp is in UNIX Epoch time (milliseconds). If no timestamp is specified, we will assume current time. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/camera/videoLink")]
		Task<object> GetVideoLinkAsync(
			[AliasAs("serial")]string serial,
			[AliasAs("timestamp")]string timestamp = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateDeviceCameraQualityAndRetentionSettings
		/// </summary>
		/// <remarks>
		/// Update quality and retention settings for the given camera
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="cameraQualityAndRetentionSettingsUpdateRequest"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/camera/qualityAndRetentionSettings")]
		Task<CameraQualityAndRetentionSettings> UpdateQualityAndRetentionSettingsAsync(
			[AliasAs("serial")]string serial,
			[Body]CameraQualityAndRetentionSettingsUpdateRequest cameraQualityAndRetentionSettingsUpdateRequest,
			CancellationToken cancellationToken = default);
	}
}
