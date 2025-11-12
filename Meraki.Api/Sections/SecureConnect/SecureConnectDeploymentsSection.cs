using Meraki.Api.Interfaces.SecureConnect.Deployments;

namespace Meraki.Api.Sections.SecureConnect;
/// <summary>
/// Provides access to secure connect deployments API endpoints
/// </summary>
public class SecureConnectDeploymentsSection
{
	//public ISecureConnectDeploymentsDataCenter DataCenter { get; internal set; } = null!;
	/// <summary>
	/// List the network devices.
	/// </summary>

	public ISecureConnectDeploymentsNetworkDevices NetworkDevices { get; internal set; } = null!;
	/// <summary>
	/// List the tunnels for an organization.
	/// </summary>

	public ISecureConnectDeploymentsOrganizationTunnel OrganizationTunnel { get; internal set; } = null!;
	//public ISecureConnectDeploymentsPolicy Policy { get; internal set; } = null!;
}
