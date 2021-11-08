using Meraki.Api.Attributes;
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
		/// Returns sense settings for a given camera
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial id</param>
		[Get("/devices/{serial}/camera/sense/objectDetectionModels")]
		Task<CameraObjectDetectionModel> GetDeviceCameraSenseObjectDetectionModelsAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);
	}
}