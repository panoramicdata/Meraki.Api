namespace Meraki.Api.Data;

/// <summary>
/// Organization Inventory Swap Create Request
/// </summary>
[DataContract]
public class OrganizationInventorySwapCreateRequest
{
	/// <summary>
	/// List of replacments to perform
	/// </summary>
	[DataMember(Name = "swaps")]
	public List<OrganizationInventorySwapCreateRequestSwap> Swaps { get; set; } = [];
}
