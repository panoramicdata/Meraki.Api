namespace Meraki.Api.Data;

/// <summary>
/// Missing entitlements details
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionSubscriptionsComplianceStatusesViolationsByProductClassItemMissing
{
	/// <summary>
	/// List of missing entitlements
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "entitlements")]
	public List<AdministeredLicensingSubscriptionSubscriptionsComplianceStatusesViolationsByProductClassItemMissingEntitlement> Entitlements { get; set; } = [];
}
