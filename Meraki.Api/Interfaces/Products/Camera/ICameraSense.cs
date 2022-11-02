namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraSense
{
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
	/// Returns the MV Sense object detection model list for the given camera
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial id</param>
	[Get("/devices/{serial}/camera/sense/objectDetectionModels")]
	Task<List<CameraObjectDetectionModel>> GetDeviceCameraSenseObjectDetectionModelsAsync(
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default);
}
