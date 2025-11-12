namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations wireless ssids firewall API endpoints
/// </summary>
public class OrganizationsWirelessSsidsFirewallSection
{
	/// <summary>
	/// List the L2 isolation allow list MAC entry in an organization
	/// </summary>

	public IOrganizationsWirelessSsidsFirewallIsolation Isolation { get; internal set; } = null!;
}
