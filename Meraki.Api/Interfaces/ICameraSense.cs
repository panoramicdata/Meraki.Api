using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ICameraSense
	{
		/// <summary>
		/// getDeviceCameraSense
		/// </summary>
		/// <remarks>
		/// Returns sense settings for a given camera
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/camera/sense")]
		Task<CameraSense> GetDeviceCameraSense(
			[AliasAs("serial")]string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateDeviceCameraSense
		/// </summary>
		/// <remarks>
		/// Returns sense settings for a given camera
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/camera/sense")]
		Task<CameraSense> UpdateDeviceCameraSense(
			[AliasAs("serial")] string serial,
			[Body]CameraSenseUpdateRequest updateDeviceCameraSense,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getDeviceCameraSenseObjectDetectionModels
		/// </summary>
		/// <remarks>
		/// Returns sense settings for a given camera
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/camera/sense/objectDetectionModels")]
		Task<CameraObjectDetectionModel> GetDeviceCameraSenseObjectDetectionModels(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);
	}
}