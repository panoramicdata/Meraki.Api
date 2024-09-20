namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventory
{
	/// <summary>
	/// Meta details about the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public NetworkCellularGatewayEsimsInventoryMeta Meta { get; set; } = new();

	/// <summary>
	/// List of eSIM Devices
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "items")]
	public List<NetworkCellularGatewayEsimsInventoryItem> Items { get; set; } = [];

}
