namespace Meraki.Api.Sections.General.Organizations;

public partial class OrganizationsConfigTemplatesSection
{
	[RefitPromoteCalls]
	internal IOrganizationsConfigTemplates ConfigTemplates { get; set; }

	public OrganizationsConfigTemplatesSwitchSection Switch { get; set; }
}
