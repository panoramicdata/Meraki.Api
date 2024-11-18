namespace Meraki.Api.Data;

/// <summary>
/// Esims Swap Create Request
/// </summary>
[DataContract]
public class OrganizationCellularGatewayEsimSwapCreateRequest
{
	/// <summary>
	///	Each object represents a swap for one eSIM
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "swaps")]
	public List<OrganizationCellularGatewayEsimSwap> Swaps { get; set; } = [];
}
