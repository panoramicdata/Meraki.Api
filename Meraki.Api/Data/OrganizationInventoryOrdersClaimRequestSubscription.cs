namespace Meraki.Api.Data;

/// <summary>
/// Subscription
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersClaimRequestSubscription
{
	/// <summary>
	/// Subscription description
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Subscription name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Subscription ID
	/// </summary>
	[DataMember(Name = "subscriptionId")]
	public string SubscriptionId { get; set; } = string.Empty;
}