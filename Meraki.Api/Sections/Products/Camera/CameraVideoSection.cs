namespace Meraki.Api.Sections.Products.Camera;

/// <summary>
/// Provides access to camera video API endpoints
/// </summary>

public partial class CameraVideoSection
{
	/// <summary>
	/// Returns video settings for the given camera
	/// </summary>
	[RefitPromoteCalls]
	public ICameraVideo Video { get; set; } = null!;
}
