namespace Meraki.Api.Data;

/// <summary>
/// Licensing Claim Key Validation
/// </summary>
[DataContract]
public class LicensingClaimKeyValidation
{
	/// <summary>
	/// Subscription Description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Subscription expiration date
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endDate")]
	public string EndDate { get; set; } = string.Empty;

	/// <summary>
	/// Smart account status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "smartAccountStatus")]
	public string SmartAccountStatus { get; set; } = string.Empty;

	/// <summary>
	/// Subscription name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Subscription start date
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startDate")]
	public string StartDate { get; set; } = string.Empty;

	/// <summary>
	/// Subscription Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Subscription's ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subscriptionId")]
	public string SubscrptionId { get; set; } = string.Empty;

	/// <summary>
	/// Web order id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "webOrderId")]
	public string WebOrderId { get; set; } = string.Empty;

	/// <summary>
	/// Web order id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productTypes")]
	public List<string> ProductTypes { get; set; } = [];

	/// <summary>
	/// Enterprise agreement details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enterpriseAgreement")]
	public LicensingSubscriptionClaimEnterpriseAgreement EnterpriseAgreement { get; set; } = new();

	/// <summary>
	/// Smart account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "smartAccount")]
	public LicensingSubscriptionClaimSmartAccount SmartAccount { get; set; } = new();

	/// <summary>
	/// Numeric breakdown of network and entitlement counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public LicensingSubscriptionClaimCounts Counts { get; set; } = new();

	/// <summary>
	/// Entitlement info
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "entitlements")]
	public List<LicensingSubscriptionClaimEntitlement> Entitlements { get; set; } = [];
}