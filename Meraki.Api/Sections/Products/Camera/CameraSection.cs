namespace Meraki.Api.Sections.Products.Camera;

public class CameraSection
{
	public ICameraQualityAndRetention QualityAndRetention { get; internal set; } = null!;
	public CameraAnalyticsSection Analytics { get; internal set; } = new();
}
