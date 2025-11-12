namespace Meraki.Api.Sections.Products.CellularGateway;

/// <summary>
/// Provides access to cellular gateway uplink API endpoints
/// </summary>

public partial class CellularGatewayUplinkSection
{
	[RefitPromoteCalls]
	internal ICellularGatewayUplink Uplink { get; set; } = null!;
	/// <summary>
	/// List the uplink status of every Meraki MG cellular gateway in the organization
	/// </summary>

	public ICellularGatewayUplinkStatuses Statuses { get; internal set; } = null!;
}
