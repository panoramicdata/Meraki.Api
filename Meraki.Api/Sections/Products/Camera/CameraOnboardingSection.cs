namespace Meraki.Api.Sections.Products.Camera;

/// <summary>
/// Provides access to camera onboarding API endpoints
/// </summary>

public partial class CameraOnboardingSection
{
	/// <summary>
	/// Fetch onboarding status of cameras
	/// </summary>
	[RefitPromoteCalls]
	public ICameraOnbording Onbording { get; set; } = null!;
}
