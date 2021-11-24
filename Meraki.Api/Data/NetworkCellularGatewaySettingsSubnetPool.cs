namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Subnet Pool
/// </summary>
[DataContract]
public class NetworkCellularGatewaySettingsSubnetPool : NetworkCellularGatewaySettingsSubnetPoolUpdateRequest
{
	/// <summary>
	/// Subnets
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnets")]
	public List<CellularGatewaySubnet> Subnets { get; set; } = new();
}
