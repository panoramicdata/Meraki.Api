namespace Meraki.Api.Sections.Products.Camera;

/// <summary>
/// Provides access to camera sense API endpoints
/// </summary>

public partial class CameraSenseSection
{
	/// <summary>
	/// Returns sense settings for a given camera
	/// </summary>
	[RefitPromoteCalls]
	public ICameraSense Sense { get; set; } = null!;
}
