namespace Meraki.Api.Sections.General.Organizations;
public class OrganizationsCameraSection
{
	public IOrganizationsCameraPermissions Permissions { get; internal set; } = null!;

	public IOrganizationsCameraDetections Detections { get; internal set; } = null!;
}
