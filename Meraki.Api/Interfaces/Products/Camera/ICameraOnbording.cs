namespace Meraki.Api.Interfaces.Products.Camera;

/// <summary>
/// I Camera Onbording
/// </summary>
public interface ICameraOnbording
{
	/// <summary>
	/// Fetch onboarding status of cameras
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="serials"></param>
	/// <param name="networkIds"></param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/camera/onboarding/statuses")]
	Task<List<OnboardingStatus>> GetOrganizationCameraOnboardingStatusesAsync(
		string organizationId,
		[AliasAs("serials[]")] List<string>? serials = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Notify that credential handoff to camera has completed
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="unboardingStatusUpdateRequest"></param>
	/// <param name="cancellationToken"></param>
	[Put("/organizations/{organizationId}/camera/onboarding/statuses")]
	Task<ActionResponse> UpdateOrganizationCameraOnboardingStatusesAsync(
		string organizationId,
		[Body] OnboardingStatusUpdateRequest unboardingStatusUpdateRequest,
		CancellationToken cancellationToken = default
		);
}
