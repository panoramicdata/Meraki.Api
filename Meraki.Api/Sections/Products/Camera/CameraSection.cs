namespace Meraki.Api.Sections.Products.Camera;

public class CameraSection
{
	public ICamera Camera { get; internal set; } = null!;
	public ICameraQualityAndRetentionProfiles QualityAndRetentionProfiles { get; internal set; } = null!;
	public CameraAnalyticsSection Analytics { get; internal set; } = new();
}
