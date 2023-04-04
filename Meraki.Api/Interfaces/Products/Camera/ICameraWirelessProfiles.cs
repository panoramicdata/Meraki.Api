namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraWirelessProfiles
{
	/// <summary>
	/// Returns wireless profile assigned to the given camera
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[ApiOperationId("getDeviceCameraWirelessProfiles")]
	[Get("/devices/{serial}/camera/wirelessProfiles")]
	Task<CameraWirelessProfiles> GetDeviceCameraWirelessProfilesAsync(
		string serial,
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
		string serial,
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
	Task<List<NetworkCameraWirelessProfile>> GetNetworkCameraWirelessProfilesAsync(
		string networkId,
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
	Task<NetworkCameraWirelessProfile> GetNetworkCameraWirelessProfileAsync(
		string networkId,
		string wirelessProfileId,
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
	Task<NetworkCameraWirelessProfile> UpdateNetworkCameraWirelessProfileAsync(
		string networkId,
		string wirelessProfileId,
		[Body] NetworkCameraWirelessProfileCreateUpdateRequest updateNetworkCameraWirelessProfile,
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
	Task<NetworkCameraWirelessProfile> CreateNetworkCameraWirelessProfileAsync(
		string networkId,
		[Body] NetworkCameraWirelessProfileCreateUpdateRequest createNetworkCameraWirelessProfile,
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
		string networkId,
		string wirelessProfileId,
		CancellationToken cancellationToken = default);
}
