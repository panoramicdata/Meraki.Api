namespace Meraki.Api.Sections.General.Networks;

/// <summary>
/// Provides access to networks sensor API endpoints
/// </summary>
public class NetworksSensorSection
{
	/// <summary>
	/// Gets the alerts
	/// </summary>

	public NetworksSensorAlertsSection Alerts { get; internal set; } = new();

	/// <summary>
	/// Returns a list of all sensor schedules.
	/// </summary>

	public INetworksSensorSchedules Schedules { get; internal set; } = null!;
}
