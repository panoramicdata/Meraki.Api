namespace Meraki.Api.Sections.Products.Camera;

public class CameraAnalyticsSection
{
	public ICameraAnalyticsLive Live { get; internal set; } = null!;
	public ICameraAnalyticsOverview Overview { get; internal set; } = null!;
	public ICameraAnalyticsRecent Recent { get; internal set; } = null!;
	public ICameraAnalyticsZones Zones { get; internal set; } = null!;
}