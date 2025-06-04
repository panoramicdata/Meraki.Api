namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsApplianceSection
{
	public OrganizationsApplianceDnsSection Dns { get; internal set; } = new();

	public IOrganizationsApplianceSdwan Sdwan { get; internal set; } = null!;

	public OrganizationsApplianceUplinksSection Uplinks { get; internal set; } = new();
}
