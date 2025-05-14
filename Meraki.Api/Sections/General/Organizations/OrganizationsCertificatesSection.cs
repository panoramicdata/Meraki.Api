namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsCertificatesSection
{
	[RefitPromoteCalls]
	public IOrganizationsCertificates Certificates { get; set; } = null!;
}
