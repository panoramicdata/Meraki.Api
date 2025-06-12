namespace Meraki.Api.Sections.General.Networks;
public class NetworksSwitchSection
{
	public INetworksSwitchPorts Ports { get; internal set; } = null!;

	public INetworksSwitchDhcp Dhcp { get; internal set; } = null!;

	public INetworksSwitchDhcpServerPolicy DhcpServerPolicy { get; internal set; } = null!;

	public INetworksSwitchStack Stacks { get; internal set; } = null!;

}
