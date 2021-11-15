namespace Meraki.Api.Sections.Products.CellularGateway;

public class CellularGatewayUplinkSection
{
	public ICellularGatewayUplink Uplink { get; internal set; } = null!;
	public ICellularGatewayUplinkStatuses Statuses { get; internal set; } = null!;
}
