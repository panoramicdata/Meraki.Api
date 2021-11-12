namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsAdaptivePolicySection
{
	public IOrganizationsAdaptivePolicyAcls Acls { get; internal set; } = null!;
	public IOrganizationsAdaptivePolicySettings Settings { get; internal set; } = null!;
}