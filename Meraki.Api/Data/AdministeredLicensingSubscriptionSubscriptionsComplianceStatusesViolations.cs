namespace Meraki.Api.Data;

/// <summary>
/// Violations
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionSubscriptionsComplianceStatusesViolations
{
	/// <summary>
	/// List of violations by product class that are not compliance
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byProductClass")]
	public List<AdministeredLicensingSubscriptionSubscriptionsComplianceStatusesViolationsByProductClassItem> ByProductClass { get; set; } = [];
}
