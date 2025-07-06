namespace Meraki.Api.Sections.General.Organizations;
public class OrganizationsApplianceDnsSection
{
	public OrganizationsApplianceDnsLocalSection Local { get; internal set; } = new();

	public OrganizationsApplianceDnsSplitSection Split { get; internal set; } = new();
}
