namespace Meraki.Api.Data;

/// <summary>
/// Violation by product class that are not compliance
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionSubscriptionsComplianceStatusesViolationsByProductClassItem
{
	/// <summary>
	/// End date of the grace period in ISO 8601 format
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "gracePeriodEndsAt")]
	public string GracePeriodEndsAt { get; set; } = string.Empty;

	/// <summary>
	/// Name of the product class
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productClass")]
	public string ProductClass { get; set; } = string.Empty;

	/// <summary>
	/// Missing entitlements details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "missing")]
	public AdministeredLicensingSubscriptionSubscriptionsComplianceStatusesViolationsByProductClassItemMissing Missing { get; set; } = new();
}
