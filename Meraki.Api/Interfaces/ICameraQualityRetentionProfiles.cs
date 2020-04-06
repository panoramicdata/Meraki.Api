using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ICameraQualityRetentionProfiles
	{
		/// <summary>
		/// createNetworkCameraQualityRetentionProfile
		/// </summary>
		/// <remarks>
		/// Creates new quality retention profile for this network.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkCameraQualityRetentionProfile"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/camera/qualityRetentionProfiles")]
		Task<CameraQualityAndRetentionSettings> CreateAsync(
			[AliasAs("networkId")]string networkId,
			[Body]CameraQualityAndRetentionProfileCreationRequest createNetworkCameraQualityRetentionProfile,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// deleteNetworkCameraQualityRetentionProfile
		/// </summary>
		/// <remarks>
		/// Delete an existing quality retention profile for this network.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="qualityRetentionProfileId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}")]
		Task DeleteAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("qualityRetentionProfileId")]string qualityRetentionProfileId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkCameraQualityRetentionProfile
		/// </summary>
		/// <remarks>
		/// Retrieve a single quality retention profile
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="qualityRetentionProfileId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}")]
		Task<object> GetAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("qualityRetentionProfileId")]string qualityRetentionProfileId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkCameraQualityRetentionProfiles
		/// </summary>
		/// <remarks>
		/// List the quality retention profiles for this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/camera/qualityRetentionProfiles")]
		Task<object> GetAllAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkCameraQualityRetentionProfile
		/// </summary>
		/// <remarks>
		/// Update an existing quality retention profile for this network.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="qualityRetentionProfileId"></param>
		/// <param name="updateNetworkCameraQualityRetentionProfile"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}")]
		Task<CameraQualityAndRetentionSettings> UpdateAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("qualityRetentionProfileId")]string qualityRetentionProfileId,
			[Body]CameraQualityAndRetentionProfileUpdateRequest updateNetworkCameraQualityRetentionProfile,
			CancellationToken cancellationToken = default);
	}
}
