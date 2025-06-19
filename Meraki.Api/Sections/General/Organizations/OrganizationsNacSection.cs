namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsNacSection
{
	public IOrganizationsNacAuthorization Authorization { get; internal set; } = null!;

	public IOrganizationsNacSessions Sessions { get; internal set; } = null!;
}