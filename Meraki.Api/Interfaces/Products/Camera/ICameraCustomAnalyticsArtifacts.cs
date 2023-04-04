namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraCustomAnalyticsArtifacts
{
	/// <summary>
	/// List Custom Analytics Artifacts
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization Id</param>
	[Get("/organizations/{organizationId}/camera/customAnalytics/artifacts")]
	Task<List<CameraCustomAnalyticsArtifact>> GetOrganizationCameraCustomAnalyticsArtifactsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create custom analytics artifact. Returns an artifact upload URL with expiry time. 
	/// Upload the artifact file with a put request to the returned upload URL before its expiry.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cameraCustomAnalyticsArtifactCreateRequest">Body for updating camera custom analytics</param>
	[Post("/organizations/{organizationId}/camera/customAnalytics/artifacts")]
	Task<CameraCustomAnalyticsArtifactCreateResponse> CreateOrganizationCameraCustomAnalyticsArtifactAsync(
		string serial,
		[Body] CameraCustomAnalyticsArtifactCreateRequest cameraCustomAnalyticsArtifactCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Get Custom Analytics Artifact
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization Id</param>
	/// <param name="artifactId">The artifact Id</param>
	[Get("/organizations/{organizationId}/camera/customAnalytics/artifacts/{artifactId}")]
	Task<CameraCustomAnalyticsArtifact> GetOrganizationCameraCustomAnalyticsArtifactAsync(
		string organizationId,
		string artifactId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete Custom Analytics Artifact
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="artifactId">The artifact id</param>
	[Delete("/organizations/{organizationId}/camera/customAnalytics/artifacts/{artifactId}")]
	Task DeleteOrganizationCameraCustomAnalyticsArtifactAsync(
		string organizationId,
		string artifactId,
		CancellationToken cancellationToken = default);
}
