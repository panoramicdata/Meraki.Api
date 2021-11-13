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

		/// <summary>
		/// Returns sense settings for a given camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial id</param>
		[ApiOperationId("getDeviceCameraSense")]
		[Get("/devices/{serial}/camera/sense")]
		Task<CameraSense> GetDeviceCameraSenseAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns sense settings for a given camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial id</param>
		/// <param name="cameraSense">Body for updating device camera sense</param>
		[ApiOperationId("updateDeviceCameraSense")]
		[Put("/devices/{serial}/camera/sense")]
		Task<CameraSense> UpdateDeviceCameraSenseAsync(
			[AliasAs("serial")] string serial,
			[Body] CameraSense cameraSense,
			CancellationToken cancellationToken = default);

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

		/// <summary>
		/// Returns sense settings for a given camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial id</param>
		[Get("/devices/{serial}/camera/sense/objectDetectionModels")]
		Task<CameraObjectDetectionModel> GetDeviceCameraSenseObjectDetectionModelsAsync(
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
		Task<VideoLink> GetDeviceCameraVideoLinkAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("timestamp")] string timestamp = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns wireless profile assigned to the given camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[ApiOperationId("getDeviceCameraWirelessProfiles")]
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
		[ApiOperationId("updateDeviceCameraWirelessProfiles")]
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
		[ApiOperationId("getNetworkCameraWirelessProfiles")]
		[Get("/networks/{networkId}/camera/wirelessProfiles")]
		Task<List<WirelessProfiles>> GetNetworkCameraWirelessProfilesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Retrieve a single camera wireless profile.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="wirelessProfileId">The wireless profile id</param>
		[ApiOperationId("getNetworkCameraWirelessProfile")]
		[Get("/networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}")]
		Task<WirelessProfiles> GetNetworkCameraWirelessProfileAsync(
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
		[ApiOperationId("updateNetworkCameraWirelessProfile")]
		[Put("/networks/{networkId}/camera/wirelessProfiles/{wirelessProfileId}")]
		Task<WirelessProfiles> UpdateNetworkCameraWirelessProfileAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("wirelessProfileId")] string wirelessProfileId,
			[Body] WirelessProfilesCreateUpdateRequest updateNetworkCameraWirelessProfile,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Creates a new camera wireless profile for this network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkCameraWirelessProfile">Body for creating camera wireless profile</param>
		[ApiOperationId("createNetworkCameraWirelessProfile")]
		[Post("/networks/{networkId}/camera/wirelessProfiles")]
		Task<WirelessProfiles> CreateNetworkCameraWirelessProfileAsync(
			[AliasAs("networkId")] string networkId,
			[Body] WirelessProfilesCreateUpdateRequest createNetworkCameraWirelessProfile,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete an existing camera wireless profile for this network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="wirelessProfileId">The wireless profile id</param>
		[ApiOperationId("deleteNetworkCameraWirelessProfile")]
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
