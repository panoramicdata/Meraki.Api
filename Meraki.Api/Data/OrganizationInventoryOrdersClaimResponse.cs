namespace Meraki.Api.Data;

/// <summary>
/// Organization Inventory Orders Claim Response
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersClaimResponse
{
	/// <summary>
	/// The order claim id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "claimId")]
	public string ClaimId { get; set; } = string.Empty;

	/// <summary>
	/// Order Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public string Number { get; set; } = string.Empty;

	/// <summary>
	/// All devices claimed in this order
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];

	/// <summary>
	/// Details for subscriptions claimed in this order
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subscriptions")]
	public List<OrganizationInventoryOrdersClaimResponseSubscription> Subscriptions { get; set; } = [];
}
