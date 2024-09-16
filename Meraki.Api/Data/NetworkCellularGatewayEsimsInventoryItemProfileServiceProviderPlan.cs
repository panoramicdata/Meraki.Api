namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory Item Profile Servce Provider Plan
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventoryItemProfileServiceProviderPlan
{
	/// <summary>
	/// Plan name
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Plan type (communication, rate)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;;
}
