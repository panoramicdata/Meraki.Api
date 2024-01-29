namespace Meraki.Api.Data;

/// <summary>
/// Licensing Subscription Bindings Insufficient Entitlement
/// </summary>
[DataContract]
public class LicensingSubscriptionBindingsInsufficientEntitlement
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