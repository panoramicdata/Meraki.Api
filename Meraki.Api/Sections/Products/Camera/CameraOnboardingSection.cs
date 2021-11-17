namespace Meraki.Api.Sections.Products.Camera;

public partial class CameraOnboardingSection
{
	[RefitPromoteCalls]
	public ICameraOnbording Onbording { get; set; } = null!;
}
