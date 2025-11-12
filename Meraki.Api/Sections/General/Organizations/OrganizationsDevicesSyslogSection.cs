namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations devices syslog API endpoints
/// </summary>
public class OrganizationsDevicesSyslogSection
{
	/// <summary>
	/// Gets the servers
	/// </summary>

	public OrganizationsDevicesSyslogServersSection Servers { get; internal set; } = new();
}
