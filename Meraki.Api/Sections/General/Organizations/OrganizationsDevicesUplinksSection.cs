namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations devices uplinks API endpoints
/// </summary>
public class OrganizationsDevicesUplinksSection
{
	/// <summary>
	/// List the current uplink addresses for devices in an organization.
	/// </summary>

	public IOrganizationsDevicesUplinksAddresses Addresses { get; set; } = null!;
}
