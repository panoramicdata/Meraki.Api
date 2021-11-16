namespace Meraki.Api.Sections.Products.Camera;

public partial class CameraSection
{
	[RefitPromoteCalls]
	internal ICamera Camera { get; set; } = null!;
	public ICameraQualityAndRetentionProfiles QualityAndRetentionProfiles { get; internal set; } = null!;
	public CameraAnalyticsSection Analytics { get; internal set; } = new();
}
