namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraOnbording
{
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
	Task<ActionResponse> UpdateOrganizationCameraOnboardingStatusesAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] UpdateOnboardingStatus updateNetworkCameraWirelessProfile,
		CancellationToken cancellationToken = default
		);
}
