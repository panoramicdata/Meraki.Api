namespace Meraki.Api.Sections.General.Organizations;
/// <summary>
/// Provides access to organizations camera API endpoints
/// </summary>
public class OrganizationsCameraSection
{
	/// <summary>
	/// List the permissions scopes for this organization
	/// </summary>

	public IOrganizationsCameraPermissions Permissions { get; internal set; } = null!;

	/// <summary>
	/// Returns analytics data for timespans
	/// </summary>

	public IOrganizationsCameraDetections Detections { get; internal set; } = null!;
}
