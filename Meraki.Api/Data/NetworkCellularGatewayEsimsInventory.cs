namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventory
	: ItemsResponseWithMeta<NetworkCellularGatewayEsimsInventoryItem>
{
	/// <summary>
	/// List of eSIM Devices
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	public override List<NetworkCellularGatewayEsimsInventoryItem> Items { get; set; } = [];
}
