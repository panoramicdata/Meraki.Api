namespace Meraki.Api.Sections.Products.CellularGateway;

public partial class CellularGatewayUplinkSection
{
	[RefitPromoteCalls]
	internal ICellularGatewayUplink Uplink { get; set; } = null!;
	public ICellularGatewayUplinkStatuses Statuses { get; internal set; } = null!;
}
