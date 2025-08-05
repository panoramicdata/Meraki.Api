using Meraki.Api.Interfaces.SecureConnect.Deployments;

namespace Meraki.Api.Sections.SecureConnect;
public class SecureConnectDeploymentsSection
{
	//public ISecureConnectDeploymentsDataCenter DataCenter { get; internal set; } = null!;
	public ISecureConnectDeploymentsNetworkDevices NetworkDevices { get; internal set; } = null!;
	public ISecureConnectDeploymentsOrganizationTunnel OrganizationTunnel { get; internal set; } = null!;
	//public ISecureConnectDeploymentsPolicy Policy { get; internal set; } = null!;
}
