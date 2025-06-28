namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsDevicesSyslogSection
{
	public OrganizationsDevicesSyslogServersSection Servers { get; internal set; } = new();
}
