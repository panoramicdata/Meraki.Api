namespace Meraki.Api.Sections.General.Organizations;
/// <summary>
/// Provides access to organizations sm API endpoints
/// </summary>
public class OrganizationsSmSection
{
	/// <summary>
	/// List the Limited Access Roles for an organization
	/// </summary>

	public IOrganizationsSmAdmins Admins { get; internal set; } = null!;

	/// <summary>
	/// Enqueue a sync job for an ADE account
	/// </summary>

	public IOrganizationsSmApple Apple { get; internal set; } = null!;

	/// <summary>
	/// List all BulkEnrollmentTokens for an organization.
	/// </summary>

	public IOrganizationsSmBulkEnrollment BulkEnrollment { get; internal set; } = null!;

	/// <summary>
	/// List the Sentry Policies for an organization ordered in ascending order of priority
	/// </summary>

	public IOrganizationsSmSentry Sentry { get; internal set; } = null!;
}
