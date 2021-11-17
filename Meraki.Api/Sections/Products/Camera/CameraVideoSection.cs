namespace Meraki.Api.Sections.Products.Camera;

public partial class CameraVideoSection
{
	[RefitPromoteCalls]
	public ICameraVideo Video { get; set; } = null!;
}
