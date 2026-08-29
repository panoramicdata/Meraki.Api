namespace Meraki.Api.Sections.Products.CellularGateway;

/// <summary>
/// Provides access to cellular gateway uplink API endpoints
/// </summary>

// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class CellularGatewayUplinkSection
{
	[RefitPromoteCalls]
	internal ICellularGatewayUplink Uplink { get; set; } = null!;
	/// <summary>
	/// List the uplink status of every Meraki MG cellular gateway in the organization
	/// </summary>

	public ICellularGatewayUplinkStatuses Statuses { get; internal set; } = null!;
}
#pragma warning restore S2333
