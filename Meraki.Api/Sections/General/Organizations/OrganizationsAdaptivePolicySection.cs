namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations adaptive policy API endpoints
/// </summary>
public class OrganizationsAdaptivePolicySection
{
	/// <summary>
	/// List adaptive policy ACLs in a organization
	/// </summary>

	public IOrganizationsAdaptivePolicyAcls Acls { get; internal set; } = null!;
	/// <summary>
	/// Returns global adaptive policy settings in an organization
	/// </summary>

	public IOrganizationsAdaptivePolicySettings Settings { get; internal set; } = null!;
}
