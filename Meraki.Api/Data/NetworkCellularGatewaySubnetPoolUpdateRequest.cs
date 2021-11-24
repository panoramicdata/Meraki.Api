namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkCellularGatewaySettingsSubnetPool
/// </summary>
[DataContract]
public class NetworkCellularGatewaySubnetPoolUpdateRequest
{
	/// <summary>
	/// CIDR of the pool of subnets. Each MG in this network will automatically pick a subnet from this pool.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "cidr")]
	public string Cidr { get; set; } = string.Empty;

	/// <summary>
	/// Mask used for the subnet of all MGs in  this network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mask")]
	public int? Mask { get; set; }
}
