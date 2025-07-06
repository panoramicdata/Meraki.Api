namespace Meraki.Api.Sections.General.Networks;

public partial class NetworksAlertsSection
{
	[RefitPromoteCalls]
	internal INetworksAlerts NetworksAlerts { get; set; } = null!;

	public INetworksAlertsSettings Settings { get; internal set; } = null!;
}
