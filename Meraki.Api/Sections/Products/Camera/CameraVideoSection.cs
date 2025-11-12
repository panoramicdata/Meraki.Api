namespace Meraki.Api.Sections.Products.Camera;

public partial class CameraVideoSection
{
	/// <summary>
	/// Returns video settings for the given camera
	/// </summary>
	[RefitPromoteCalls]
	public ICameraVideo Video { get; set; } = null!;
}
