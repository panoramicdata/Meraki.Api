namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Subnet Pool
/// </summary>
[DataContract]
public class NetworkCellularGatewaySubnetPool : NetworkCellularGatewaySubnetPoolUpdateRequest
{
	/// <summary>
	/// Subnets
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnets")]
	public List<CellularGatewaySubnet> Subnets { get; set; } = [];
}
