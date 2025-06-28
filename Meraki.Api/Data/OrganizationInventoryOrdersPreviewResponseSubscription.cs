namespace Meraki.Api.Data;

/// <summary>
/// Subscription details for this order
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewResponseSubscription
{
	/// <summary>
	/// Subscription description
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The date this subscription will end
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endDate")]
	public string EndDate { get; set; } = string.Empty;

	/// <summary>
	/// Subscription name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The date this subscription will begin
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startDate")]
	public string StartDate { get; set; } = string.Empty;

	/// <summary>
	/// Subscription ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subscriptionId")]
	public string SubscriptionId { get; set; } = string.Empty;

	/// <summary>
	/// Whether the subscription has been claimed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isClaimed")]
	public bool IsClaimed { get; set; }

	/// <summary>
	/// Numeric breakdown of subscription counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationInventoryOrdersPreviewResponseSubscriptionCounts Counts { get; set; } = new();
}
