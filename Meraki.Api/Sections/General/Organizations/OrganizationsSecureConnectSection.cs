namespace Meraki.Api.Sections.General.Organizations;
public class OrganizationsSecureConnectSection
{
	public IOrganizationsSecureConnectPrivateApplications PrivateApplications { get; internal set; } = null!;

	public IOrganizationsSecureConnectPrivateApplicationGroups PrivateApplicationGroups { get; internal set; } = null!;
}
