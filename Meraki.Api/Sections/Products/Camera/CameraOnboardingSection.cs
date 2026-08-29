namespace Meraki.Api.Sections.Products.Camera;

/// <summary>
/// Provides access to camera onboarding API endpoints
/// </summary>

// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class CameraOnboardingSection
{
	/// <summary>
	/// Fetch onboarding status of cameras
	/// </summary>
	[RefitPromoteCalls]
	public ICameraOnbording Onbording { get; set; } = null!;
}
#pragma warning restore S2333
