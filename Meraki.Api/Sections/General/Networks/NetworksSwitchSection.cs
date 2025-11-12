namespace Meraki.Api.Sections.General.Networks;
/// <summary>
/// Provides access to networks switch API endpoints
/// </summary>
public class NetworksSwitchSection
{
	/// <summary>
	/// List the port profiles in a network
	/// </summary>

	public INetworksSwitchPorts Ports { get; internal set; } = null!;

	/// <summary>
	/// Return the network's DHCPv4 servers seen within the selected timeframe (default 1 day)
	/// </summary>

	public INetworksSwitchDhcp Dhcp { get; internal set; } = null!;

	/// <summary>
	/// Return the devices that have a Dynamic ARP Inspection warning and their warnings
	/// </summary>

	public INetworksSwitchDhcpServerPolicy DhcpServerPolicy { get; internal set; } = null!;

	/// <summary>
	/// Update switch port mirrors for switch stacks
	/// </summary>

	public INetworksSwitchStack Stacks { get; internal set; } = null!;

}
