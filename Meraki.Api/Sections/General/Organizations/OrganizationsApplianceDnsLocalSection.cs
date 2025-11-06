namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsApplianceDnsLocalSection
{
	public IOrganizationsApplianceDnsLocalProfiles Profiles { get; internal set; } = null!;

	public IOrganizationsApplianceDnsLocalRecord Records { get; set; } = null!;
}
