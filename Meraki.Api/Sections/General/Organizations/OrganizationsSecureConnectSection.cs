namespace Meraki.Api.Sections.General.Organizations;
/// <summary>
/// Provides access to organizations secure connect API endpoints
/// </summary>
public class OrganizationsSecureConnectSection
{
	/// <summary>
	/// Provides a list of private applications for an Organization
	/// </summary>

	public IOrganizationsSecureConnectPrivateApplications PrivateApplications { get; internal set; } = null!;

	/// <summary>
	/// Provides a list of private application groups for an Organization
	/// </summary>

	public IOrganizationsSecureConnectPrivateApplicationGroups PrivateApplicationGroups { get; internal set; } = null!;

	/// <summary>
	/// Provides a list of private resources for an organization.
	/// </summary>

	public IOrganizationsSecureConnectPrivateResources PrivateResources { get; internal set; } = null!;

	/// <summary>
	/// Provides a list of the private resource groups in an organization.
	/// </summary>

	public IOrganizationsSecureConnectPrivateResourceGroups PrivateResourceGroups { get; internal set; } = null!;

	/// <summary>
	/// Provides a list of public applications for an Organization.
	/// </summary>

	public IOrganizationsSecureConnectPublicApplications PublicApplications { get; internal set; } = null!;

	/// <summary>
	/// List deployed cloud hubs and regions in this organization
	/// </summary>

	public IOrganizationsSecureConnectRegions Regions { get; internal set; } = null!;

	/// <summary>
	/// List the latest 5000 events logged by remote access.
	/// </summary>

	public IOrganizationsSecureConnectRemoteAccessLog RemoteAccessLog { get; internal set; } = null!;

	/// <summary>
	/// Provides a list of remote access logs exports for an Organization
	/// </summary>

	public IOrganizationsSecureConnectRemoteAccessLogsExports RemoteAccessLogsExports { get; internal set; } = null!;

	/// <summary>
	/// List sites in this organization
	/// </summary>

	public IOrganizationsSecureConnectSites Sites { get; internal set; } = null!;
}
