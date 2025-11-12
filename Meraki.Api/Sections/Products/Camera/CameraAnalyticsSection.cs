namespace Meraki.Api.Sections.Products.Camera;

/// <summary>
/// Provides access to camera analytics API endpoints
/// </summary>
public class CameraAnalyticsSection
{
	/// <summary>
	/// Returns live state from camera analytics zones
	/// </summary>

	public ICameraAnalyticsLive Live { get; internal set; } = null!;
	/// <summary>
	/// Returns an overview of aggregate analytics data for a timespan
	/// </summary>

	public ICameraAnalyticsOverview Overview { get; internal set; } = null!;
	/// <summary>
	/// Returns most recent record for analytics zones
	/// </summary>

	public ICameraAnalyticsRecent Recent { get; internal set; } = null!;
	/// <summary>
	/// Return historical records for analytic zones
	/// </summary>

	public ICameraAnalyticsZones Zones { get; internal set; } = null!;
}
