namespace Meraki.Api.Sections.Products.Camera;

public partial class CameraSenseSection
{
	/// <summary>
	/// Returns sense settings for a given camera
	/// </summary>
	[RefitPromoteCalls]
	public ICameraSense Sense { get; set; } = null!;
}
