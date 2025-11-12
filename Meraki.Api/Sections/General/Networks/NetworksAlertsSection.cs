namespace Meraki.Api.Sections.General.Networks;

public partial class NetworksAlertsSection
{
	[RefitPromoteCalls]
	internal INetworksAlerts NetworksAlerts { get; set; } = null!;

	/// <summary>
	/// Return the alert configuration for this network
	/// </summary>

	public INetworksAlertsSettings Settings { get; internal set; } = null!;
}
