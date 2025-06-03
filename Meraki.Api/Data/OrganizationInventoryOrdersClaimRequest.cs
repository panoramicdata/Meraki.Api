namespace Meraki.Api.Data;

/// <summary>
/// Organization Inventory Orders Claim Request
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersClaimRequest
{
	/// <summary>
	/// The unique order claim id
	/// </summary>
	[DataMember(Name = "claimId")]
	public string ClaimId { get; set; } = string.Empty;

	/// <summary>
	/// The individual subscriptions to claim
	/// </summary>
	[DataMember(Name = "subscriptions")]
	public List<OrganizationInventoryOrdersClaimRequestSubscription>? Subscriptions { get; set; }
}
