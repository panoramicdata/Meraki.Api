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
		/// Generate a snapshot of what the camera sees at the specified time and return a link to that image.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="generateNetworkCameraSnapshot">Body for generating network camera snapshot</param>
		[Post("/devices/{serial}/camera/generateSnapshot")]
		Task<CameraSnapshot> GetSnapshotAsync(
			[AliasAs("serial")] string serial,
			[Body] CameraSnapshotRequest generateNetworkCameraSnapshot,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns quality and retention settings for the given camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Get("/devices/{serial}/camera/qualityAndRetention")]
		Task<CameraQualityAndRetentionSettings> GetQualityAndRetentionSettingsAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns a list of all camera recording schedules.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/camera/schedules")]
		Task<List<CameraSchedule>> GetSchedulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns video link to the specified camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="timestamp">[optional] The video link will start at this timestamp. The timestamp is in UNIX Epoch time (milliseconds). If no timestamp is specified, we will assume current time. (optional)</param>
		[Get("/devices/{serial}/camera/videoLink")]
		Task<VideoLink> GetVideoLinkAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("timestamp")] string timestamp = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update quality and retention settings for the given camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="cameraQualityAndRetentionSettingsUpdateRequest">Body for updating camera quality and retention settings</param>
		[Put("/devices/{serial}/camera/qualityAndRetention")]
		Task<CameraQualityAndRetentionSettings> UpdateQualityAndRetentionSettingsAsync(
			[AliasAs("serial")] string serial,
			[Body] CameraQualityAndRetentionSettingsUpdateRequest cameraQualityAndRetentionSettingsUpdateRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns wireless profile assigned to the given camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Get("/devices/{serial}/camera/wirelessProfiles")]
		Task<CameraWirelessProfiles> GetDeviceCameraWirelessProfilesAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Assign wireless profiles to the given camera.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="updateDeviceCameraWirelessProfiles">Body for updating camera wireless profiles</param>
		[Put("/devices/{serial}/camera/wirelessProfiles")]
		Task<CameraWirelessProfiles> UpdateDeviceCameraWirelessProfilesAsync(
			[AliasAs("serial")] string serial,
			[Body] CameraWirelessProfiles updateDeviceCameraWirelessProfiles,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the camera wireless profiles for this network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/camera/wirelessProfiles")]
		Task<List<NetworkWirelessProfiles>> GetNetworkCameraWirelessProfilesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Retrieve a single camera wireless profile.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="wirelessProfileId">The wireless profile id</param>
		[Get("/networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}")]
		Task<NetworkWirelessProfiles> GetNetworkCameraWirelessProfileAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("wirelessProfileId")] string wirelessProfileId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update an existing camera wireless profile in this network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="wirelessProfileId">The wireless profile id</param>
		/// <param name="updateNetworkCameraWirelessProfile">Body for updating camera wireless profile</param>
		[Put("/networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}")]
		Task<NetworkWirelessProfiles> UpdateNetworkCameraWirelessProfileAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("wirelessProfileId")] string wirelessProfileId,
			[Body] NetworkWirelessProfilesCreateRequest updateNetworkCameraWirelessProfile,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Creates a new camera wireless profile for this network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkCameraWirelessProfile">Body for creating camera wireless profile</param>
		[Post("/networks/{networkId}/camera/wirelessProfiles")]
		Task<NetworkWirelessProfiles> CreateNetworkCameraWirelessProfileAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkWirelessProfilesCreateRequest createNetworkCameraWirelessProfile,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete an existing camera wireless profile for this network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="wirelessProfileId">The wireless profile id</param>
		[Delete("/networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}")]
		Task DeleteNetworkCameraWirelessProfileAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("wirelessProfileId")] string wirelessProfileId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Fetch onboarding status of cameras
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/camera/onboarding/statuses")]
		Task<List<OnboardingStatus>> GetOrganizationCameraOnboardingStatusesAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("serials")] List<string>? serials = null,
			[AliasAs("networkIds")] List<string>? networkIds = null,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Notify that credential handoff to camera has completed
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Put("/organizations/{organizationId}/camera/onboarding/statuses")]
		Task<UpdateOnboardingStatusResponse> UpdateOrganizationCameraOnboardingStatusesAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] UpdateOnboardingStatus updateNetworkCameraWirelessProfile,
			CancellationToken cancellationToken = default
			);
	}
}
