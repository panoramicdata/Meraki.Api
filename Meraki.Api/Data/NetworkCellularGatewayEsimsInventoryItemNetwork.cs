namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory Item Network
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventoryItemNetwork
{
	/// <summary>
	/// Network ID for this eSIM
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

}
