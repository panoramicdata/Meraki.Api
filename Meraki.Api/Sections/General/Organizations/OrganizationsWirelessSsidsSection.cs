namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations wireless ssids API endpoints
/// </summary>
public class OrganizationsWirelessSsidsSection
{
	/// <summary>
	/// Gets the firewall
	/// </summary>

	public OrganizationsWirelessSsidsFirewallSection Firewall { get; internal set; } = new();
}
