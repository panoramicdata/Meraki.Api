namespace Meraki.Api.Data;

/// <summary>
/// Administered Licensing Subscription Subscriptions Compliance Statuses
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionSubscriptionsComplianceStatuses
{
	/// <summary>
	/// Subscription details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subscription")]
	public AdministeredLicensingSubscriptionSubscriptionsComplianceStatusesSubscription Subscription { get; set; } = new();

	/// <summary>
	/// Violations
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "violations")]
	public AdministeredLicensingSubscriptionSubscriptionsComplianceStatusesViolations Violations { get; set; } = new();
}
