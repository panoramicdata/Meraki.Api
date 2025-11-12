namespace Meraki.Api.Sections.Products.Camera;

public partial class CameraOnboardingSection
{
	/// <summary>
	/// Fetch onboarding status of cameras
	/// </summary>
	[RefitPromoteCalls]
	public ICameraOnbording Onbording { get; set; } = null!;
}
