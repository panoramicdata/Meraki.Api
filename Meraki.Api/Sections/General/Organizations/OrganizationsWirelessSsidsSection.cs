namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsWirelessSsidsSection
{
	public OrganizationsWirelessSsidsFirewallSection Firewall { get; internal set; } = new();
}
