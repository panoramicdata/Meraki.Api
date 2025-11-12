namespace Meraki.Api.Sections.Products.CellularGateway;

/// <summary>
/// Provides access to cellular gateway API endpoints
/// </summary>
public class CellularGatewaySection
{
	/// <summary>
	/// Return the connectivity testing destinations for an MG network
	/// </summary>

	public ICellularGatewayConnectivityMonitoringDestinations ConnectivityMonitoringDestinations { get; internal set; } = null!;
	/// <summary>
	/// List common DHCP settings of MGs
	/// </summary>

	public ICellularGatewayDhcp Dhcp { get; internal set; } = null!;
	/// <summary>
	/// The eSIM inventory of a given organization.
	/// </summary>

	public ICellularGatewayEsims Esims { get; internal set; } = null!;
	/// <summary>
	/// Show the LAN Settings of a MG
	/// </summary>

	public ICellularGatewayLan Lan { get; internal set; } = null!;
	/// <summary>
	/// Returns the port forwarding rules for a single MG.
	/// </summary>

	public ICellularGatewayPortForwardingRules PortForwardingRules { get; internal set; } = null!;
	/// <summary>
	/// Return the subnet pool and mask configured for MGs in the network.
	/// </summary>

	public ICellularGatewaySubnetPool SubnetPool { get; internal set; } = null!;
	/// <summary>
	/// Gets the uplink
	/// </summary>

	public CellularGatewayUplinkSection Uplink { get; internal set; } = new();
}
