namespace Meraki.Api.Data;

/// <summary>
/// Administered Licensing Subscription Entitlements
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionEntitlements
{
	/// <summary>
	/// The feature tier associated with the entitlement (null for add-ons)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "featureTier")]
	public string FeatureTier { get; set; } = string.Empty;

	/// <summary>
	/// The user-facing name of the entitlement
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The product class associated with the entitlement
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productClass")]
	public string ProductClass { get; set; } = string.Empty;

	/// <summary>
	/// The product type of the entitlement
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public string ProductType { get; set; } = string.Empty;

	/// <summary>
	/// The SKU identifier of the entitlement
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sku")]
	public string Sku { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not the entitlement is an add-on
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isAddOn")]
	public bool IsAddOn { get; set; }
}
