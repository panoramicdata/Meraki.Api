namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsCertificatesSection
{
	[RefitPromoteCalls]
	public IOrganizationsCertificates Certificates { get; internal set; } = null!;

	public OrganizationsCertificatesRadSecSection RadSec { get; internal set; } = null!;
}
