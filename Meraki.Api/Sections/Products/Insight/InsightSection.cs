namespace Meraki.Api.Sections.Products.Insight;

/// <summary>
/// Provides access to insight API endpoints
/// </summary>
public class InsightSection
{
	/// <summary>
	/// Gets the applications
	/// </summary>

	public InsightApplicationsSection Applications { get; internal set; } = new();
	/// <summary>
	/// List the monitored media servers for this organization
	/// </summary>

	public IInsightMonitoredMediaServers MonitoredMediaServers { get; internal set; } = null!;
}
