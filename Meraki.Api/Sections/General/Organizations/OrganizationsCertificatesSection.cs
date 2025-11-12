namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsCertificatesSection
{
	/// <summary>
	/// Gets all or specific certificates for an organization
	/// </summary>
	[RefitPromoteCalls]
	public IOrganizationsCertificates Certificates { get; internal set; } = null!;

	/// <summary>
	/// Gets the rad sec
	/// </summary>

	public OrganizationsCertificatesRadSecSection RadSec { get; internal set; } = null!;
}
