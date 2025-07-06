namespace Meraki.Api.Data;

/// <summary>
/// Subscription details
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionSubscriptionsComplianceStatusesSubscription
{
	/// <summary>
	/// Subscription's ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Friendly name to identify the subscription
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// One of the following: "inactive" | "active" | "out_of_compliance" | "expired" | "canceled"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public SubscriptionStatus Status { get; set; }
}
