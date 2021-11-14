namespace Meraki.Api.Sections.Products.Camera;

public class CameraSection
{
	public ICamera Camera { get; internal set; } = null!;
	public ICameraQualityAndRetention QualityAndRetention { get; internal set; } = null!;
	public CameraAnalyticsSection Analytics { get; internal set; } = new();
}
