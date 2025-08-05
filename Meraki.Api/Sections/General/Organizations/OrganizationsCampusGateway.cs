namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsCampusGateway
{
	public IOrganizationsCampusGatewayClusters Clusters { get; internal set; } = null!;

	public OrganizationsCampusGatewayDevices Devices { get; internal set; } = new();
}
