namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory Item Profile Servce Provider
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventoryItemProfileServiceProvider
{
	/// <summary>
	/// Service Provider name
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Plans currently active on the eSIM
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "plans")]
	public List<NetworkCellularGatewayEsimsInventoryItemProfileServiceProviderPlan> Plans { get; set; } = [];
}
