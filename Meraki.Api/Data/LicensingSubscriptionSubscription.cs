namespace Meraki.Api.Data;

/// <summary>
/// Licensing SubscriptionSubscription
/// </summary>
[DataContract]
public class LicensingSubscriptionSubscription
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
	public DateTime EndDate { get; set; }

	/// <summary>
	/// When the subscription was last changed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUpdatedAt")]
	public DateTime LastUpdatedAt { get; set; }

	/// <summary>
	/// Subscription name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Smart account status
	/// </summary>
	[Obsolete("Removed in Merak API v 1.53")]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "smartAccountStatus")]
	public string SmartAccountStatus { get; set; } = string.Empty;

	/// <summary>
	/// Subscription start date
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startDate")]
	public DateTime StartDate { get; set; }

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
	public string SubscriptionId { get; set; } = string.Empty;

	/// <summary>
	/// Web order id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "webOrderId")]
	public string WebOrderId { get; set; } = string.Empty;

	/// <summary>
	/// Whether a renewal has been requested for the subscription
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "renewalRequested")]
	public bool RenewalRequested { get; set; }

	/// <summary>
	/// Web order id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productTypes")]
	public List<string> ProductTypes { get; set; } = [];

	/// <summary>
	/// Numeric breakdown of network and entitlement counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public LicensingSubscriptionClaimCounts Counts { get; set; } = new();

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
	/// Entitlement info
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "entitlements")]
	public List<LicensingSubscriptionClaimEntitlement> Entitlements { get; set; } = [];
}