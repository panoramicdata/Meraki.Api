namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations config templates API endpoints
/// </summary>

public partial class OrganizationsConfigTemplatesSection
{
	[RefitPromoteCalls]
	internal IOrganizationsConfigTemplates ConfigTemplates { get; set; } = null!;

	/// <summary>
	/// Gets the switch
	/// </summary>

	public OrganizationsConfigTemplatesSwitchSection Switch { get; set; } = new();
}
