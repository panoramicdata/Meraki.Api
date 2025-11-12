namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations policies API endpoints
/// </summary>
public class OrganizationsPoliciesSection
{
	/// <summary>
	/// Get policies for all clients with policies
	/// </summary>

	public IOrganizationsPoliciesAssignments Assignments { get; internal set; } = null!;
}
