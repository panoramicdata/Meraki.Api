namespace Meraki.Api.Sections.Products.CellularGateway;

public class CellularGatewaySection
{
	public ICellularGatewayConnectivityMonitoringDestinations ConnectivityMonitoringDestinations { get; internal set; } = null!;
	public ICellularGatewayDhcp Dhcp { get; internal set; } = null!;
	public ICellularGatewayEsims Esims { get; internal set; } = null!;
	public ICellularGatewayLan Lan { get; internal set; } = null!;
	public ICellularGatewayPortForwardingRules PortForwardingRules { get; internal set; } = null!;
	public ICellularGatewaySubnetPool SubnetPool { get; internal set; } = null!;
	public CellularGatewayUplinkSection Uplink { get; internal set; } = new();
}