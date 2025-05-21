namespace Meraki.Api.Sections.General.Organizations;
public class OrganizationsSmSection
{
	public IOrganizationsSmAdmins Admins { get; internal set; } = null!;

	public IOrganizationsSmBulkEnrollment BulkEnrollment { get; internal set; } = null!;

	public IOrganizationsSmSentry Sentry { get; internal set; } = null!;
}
