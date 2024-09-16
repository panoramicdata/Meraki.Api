namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory Meta Counts Items
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventoryMetaCountsItems
{
	/// <summary>
	/// Remaining number of eSIM Devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// Total number of eSIM Devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
