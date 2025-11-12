namespace Meraki.Api.Sections.General.Networks;

/// <summary>
/// Provides access to networks sensor alerts API endpoints
/// </summary>
public class NetworksSensorAlertsSection
{
	/// <summary>
	/// Return an overview of currently alerting sensors by metric
	/// </summary>

	public INetworksSensorAlertsCurrent Current { get; internal set; } = null!;

	/// <summary>
	/// Return an overview of alert occurrences over a timespan, by metric
	/// </summary>

	public INetworksSensorAlertsOverview Overview { get; internal set; } = null!;
}
