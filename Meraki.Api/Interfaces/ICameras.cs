using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
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
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
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
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
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
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
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
		/// Returns video link to the specified camera
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
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
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="cameraQualityAndRetentionSettingsUpdateRequest"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/camera/qualityAndRetentionSettings")]
		Task<CameraQualityAndRetentionSettings> UpdateQualityAndRetentionSettingsAsync(
			[AliasAs("serial")]string serial,
			[Body]CameraQualityAndRetentionSettingsUpdateRequest cameraQualityAndRetentionSettingsUpdateRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getDeviceCameraWirelessProfiles
		/// </summary>
		/// <remarks>
		/// Returns wireless profile assigned to the given camera
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/camera/wirelessProfiles")]
		Task<WirelessProfiles> GetDeviceCameraWirelessProfiles(
			[AliasAs("serial")] string serial
			);

		/// <summary>
		/// updateDeviceCameraWirelessProfiles
		/// </summary>
		/// <remarks>
		/// Assign wireless profiles to the given camera. Incremental updates are not supported, all profile assignment need to be supplied at once.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="updateDeviceCameraWirelessProfiles"></param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/camera/wirelessProfiles")]
		Task<WirelessProfiles> UpdateDeviceCameraWirelessProfiles(
			[AliasAs("serial")] string serial,
			[Body]WirelessProfiles updateDeviceCameraWirelessProfiles
			);

		/// <summary>
		/// getNetworkCameraWirelessProfiles
		/// </summary>
		/// <remarks>
		/// List the camera wireless profiles for this network.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/camera/wirelessProfiles")]
		Task<List<NetworkWirelessProfiles>> GetNetworkCameraWirelessProfiles(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// getNetworkCameraWirelessProfile
		/// </summary>
		/// <remarks>
		/// Retrieve a single camera wireless profile.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="wirelessProfileId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}")]
		Task<NetworkWirelessProfiles> GetNetworkCameraWirelessProfile(
			[AliasAs("networkId")] string networkId,
			[AliasAs("wirelessProfileId")] string wirelessProfileId
			);

		/// <summary>
		/// updateNetworkCameraWirelessProfile
		/// </summary>
		/// <remarks>
		/// Update an existing camera wireless profile in this network.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="wirelessProfileId"></param>
		/// <param name="updateNetworkCameraWirelessProfile"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}")]
		Task<NetworkWirelessProfiles> UpdateNetworkCameraWirelessProfile(
			[AliasAs("networkId")] string networkId,
			[AliasAs("wirelessProfileId")] string wirelessProfileId,
			[Body]NetworkWirelessProfilesCreateRequest updateNetworkCameraWirelessProfile
			);

		/// <summary>
		/// createNetworkCameraWirelessProfile
		/// </summary>
		/// <remarks>
		/// Creates a new camera wireless profile for this network.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkCameraWirelessProfile"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/camera/wirelessProfiles")]
		Task<NetworkWirelessProfiles> CreateNetworkCameraWirelessProfile(
			[AliasAs("networkId")] string networkId,
			[Body]NetworkWirelessProfilesCreateRequest createNetworkCameraWirelessProfile
			);

		/// <summary>
		/// deleteNetworkCameraWirelessProfile
		/// </summary>
		/// <remarks>
		/// Delete an existing camera wireless profile for this network.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="wirelessProfileId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}")]
		Task DeleteNetworkCameraWirelessProfile(
			[AliasAs("networkId")] string networkId,
			[AliasAs("wirelessProfileId")] string wirelessProfileId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationCameraOnboardingStatuses
		/// </summary>
		/// <remarks>
		/// Fetch onboarding status of cameras
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/camera/onboarding/statuses")]
		Task<List<OnboardingStatus>> GetOrganizationCameraOnboardingStatuses(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("serials")] List<string>? serials = null,
			[AliasAs("networkIds")] List<string>? networkIds = null
			);

		/// <summary>
		/// updateOrganizationCameraOnboardingStatuses
		/// </summary>
		/// <remarks>
		/// Notify that credential handoff to camera has completed
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/camera/onboarding/statuses")]
		Task<UpdateOnboardingStatusResponse> UpdateOrganizationCameraOnboardingStatuses(
			[AliasAs("organizationId")] string organizationId,
			[Body]UpdateOnboardingStatus updateNetworkCameraWirelessProfile
			);
	}
}
