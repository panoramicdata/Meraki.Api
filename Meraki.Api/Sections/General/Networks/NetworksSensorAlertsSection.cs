namespace Meraki.Api.Sections.General.Networks;

public class NetworksSensorAlertsSection
{
	public INetworksSensorAlertsCurrent Current { get; internal set; } = null!;

	public INetworksSensorAlertsOverview Overview { get; internal set; } = null!;
}