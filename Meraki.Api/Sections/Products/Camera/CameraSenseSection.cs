namespace Meraki.Api.Sections.Products.Camera;

public partial class CameraSenseSection
{
	[RefitPromoteCalls]
	public ICameraSense Sense { get; set; } = null!;
}
