namespace Meraki.Api.Data;

/// <summary>
/// Entitlement info
/// </summary>
[DataContract]
public class LicensingSubscriptionClaimEntitlement
{
	/// <summary>
	/// SKU of the required product
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sku")]
	public string Sku { get; set; } = string.Empty;

	/// <summary>
	/// Web order line ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "webOrderLineId")]
	public string WebOrderLineId { get; set; } = string.Empty;

	/// <summary>
	/// Seat distribution
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "seats")]
	public LicensingSubscriptionClaimEntitlementSeats Seats { get; set; } = new();
}