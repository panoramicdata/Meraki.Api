namespace Meraki.Api.Data;

/// <summary>
/// Missing entitlement details
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionSubscriptionsComplianceStatusesViolationsByProductClassItemMissingEntitlement
{
	/// <summary>
	/// Number required
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "quantity")]
	public int Quantity { get; set; }

	/// <summary>
	/// SKU of the required product
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sku")]
	public string Sku { get; set; } = string.Empty;
}