namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory Meta Counts
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventoryMetaCounts
{
	/// <summary>
	/// Count of eSIM Devices available
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public NetworkCellularGatewayEsimsInventoryMetaCountsItems Items { get; set; } = new();
}
