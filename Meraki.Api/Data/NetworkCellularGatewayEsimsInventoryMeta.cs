namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory Meta
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventoryMeta
{
	/// <summary>
	/// Counts of involved entities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public NetworkCellularGatewayEsimsInventoryMetaCounts Counts { get; set; } = new();
}
