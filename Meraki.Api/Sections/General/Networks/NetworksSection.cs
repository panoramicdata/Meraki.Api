namespace Meraki.Api.Sections.General.Networks;

public class NetworksSection
{
	public NetworksAlertsSection Alerts { get; internal set; } = new();
	public IOrganizationsNetworks Networks { get; internal set; } = null!;
}
