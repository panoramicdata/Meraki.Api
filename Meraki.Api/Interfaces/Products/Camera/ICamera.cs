namespace Meraki.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICamera
{
	/// <summary>
	/// Generate a snapshot of what the camera sees at the specified time and return a link to that image.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="generateNetworkCameraSnapshot">Body for generating network camera snapshot</param>
	[Post("/devices/{serial}/camera/generateSnapshot")]
	Task<CameraSnapshot> GenerateDeviceCameraSnapshotAsync(
		string serial,
		[Body] CameraSnapshotRequest generateNetworkCameraSnapshot,
		CancellationToken cancellationToken = default);
}
