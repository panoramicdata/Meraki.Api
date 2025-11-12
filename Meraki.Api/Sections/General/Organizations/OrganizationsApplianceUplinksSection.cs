namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations appliance uplinks API endpoints
/// </summary>
public class OrganizationsApplianceUplinksSection
{
	/// <summary>
	/// Get the sent and received bytes for each uplink of all MX and Z networks within an organization. If more than one device was active during the specified timespan, then the sent and received bytes will be aggregated by interface.
	/// </summary>

	public IOrganizationsApplianceUplinksUsage Usage { get; internal set; } = null!;
}
