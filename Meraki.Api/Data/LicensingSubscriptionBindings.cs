namespace Meraki.Api.Data;

/// <summary>
/// Licensing Subscription Bindings
/// </summary>
[DataContract]
public class LicensingSubscriptionBindings
{
	/// <summary>
	/// Subscription ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subscriptionId")]
	public string SubscriptionId { get; set; } = string.Empty;

	/// <summary>
	/// Array of errors if failed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "errors")]
	public List<string>? Errors { get; set; }

	/// <summary>
	/// A list of entitlements required to successfully bind the networks to the subscription
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "insufficientEntitlements")]
	public List<LicensingSubscriptionBindingsInsufficientEntitlement>? InsufficientEntitlements { get; set; }

	/// <summary>
	/// Unbound networks
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networks")]
	public List<LicensingSubscriptionBindingsNetwork>? Networks { get; set; }
}