namespace Meraki.Api.Sections.Products.Insight;

/// <summary>
/// Provides access to insight applications API endpoints
/// </summary>
public class InsightApplicationsSection
{
	/// <summary>
	/// List all Insight tracked applications
	/// </summary>

	public IInsightApplication Applications { get; internal set; } = null!;

	/// <summary>
	/// Get application health by time
	/// </summary>

	public IInsightApplicationHealthByTime HealthByTime { get; internal set; } = null!;
}
