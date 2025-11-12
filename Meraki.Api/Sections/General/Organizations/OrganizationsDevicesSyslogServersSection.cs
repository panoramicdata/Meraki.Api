namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations devices syslog servers API endpoints
/// </summary>
public class OrganizationsDevicesSyslogServersSection
{
	/// <summary>
	/// Returns roles that can be assigned to a syslog server for a given network.
	/// </summary>

	public IOrganizationsDevicesSyslogServersRoles Roles { get; internal set; } = null!;
}
