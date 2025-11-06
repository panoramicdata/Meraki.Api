namespace Meraki.Api.Sections.General.Organizations;

public partial class OrganizationsConfigTemplatesSection
{
	[RefitPromoteCalls]
	internal IOrganizationsConfigTemplates ConfigTemplates { get; set; } = null!;

	public OrganizationsConfigTemplatesSwitchSection Switch { get; set; } = new();
}
