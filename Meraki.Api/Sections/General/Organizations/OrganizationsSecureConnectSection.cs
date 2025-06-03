namespace Meraki.Api.Sections.General.Organizations;
public class OrganizationsSecureConnectSection
{
	public IOrganizationsSecureConnectPrivateApplications PrivateApplications { get; internal set; } = null!;

	public IOrganizationsSecureConnectPrivateApplicationGroups PrivateApplicationGroups { get; internal set; } = null!;

	public IOrganizationsSecureConnectPrivateResources PrivateResources { get; internal set; } = null!;

	public IOrganizationsSecureConnectPrivateResourceGroups PrivateResourceGroups { get; internal set; } = null!;

	public IOrganizationsSecureConnectPublicApplications PublicApplications { get; internal set; } = null!;

	public IOrganizationsSecureConnectRemoteAccessLog RemoteAccessLog { get; internal set; } = null!;

	public IOrganizationsSecureConnectRemoteAccessLogsExports RemoteAccessLogsExports { get; internal set; } = null!;

	public IOrganizationsSecureConnectSites Sites { get; internal set; } = null!;
}
