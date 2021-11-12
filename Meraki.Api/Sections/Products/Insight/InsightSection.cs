namespace Meraki.Api.Sections.Products.Insight;

public class InsightSection
{
	public InsightApplicationsSection Applications { get; internal set; } = new();
	public IInsightMonitoredMediaServers MonitoredMediaServers { get; internal set; } = null!;
}
