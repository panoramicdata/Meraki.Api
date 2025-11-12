namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Organizations Campus Gateway
/// </summary>
public class OrganizationsCampusGateway
{
	/// <summary>
	/// Get the details of campus gateway clusters
	/// </summary>

	public IOrganizationsCampusGatewayClusters Clusters { get; internal set; } = null!;

	/// <summary>
	/// Return a single device
	/// </summary>

	public OrganizationsCampusGatewayDevices Devices { get; internal set; } = new();
}
