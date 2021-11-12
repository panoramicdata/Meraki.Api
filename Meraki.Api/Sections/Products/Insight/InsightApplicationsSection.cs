namespace Meraki.Api.Sections.Products.Insight;

public class InsightApplicationsSection
{
	public IInsightApplication Applications { get; internal set; } = null!;

	public IInsightApplicationHealthByTime HealthByTime { get; internal set; } = null!;
}
