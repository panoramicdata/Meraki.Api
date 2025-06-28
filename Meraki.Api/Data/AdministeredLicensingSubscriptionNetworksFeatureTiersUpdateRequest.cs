namespace Meraki.Api.Data;

/// <summary>
/// Administered Licensing Subscription Networks Feature Tiers Update Request.
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateRequest
{
	/// <summary>
	/// Flag to determine if the operation should act atomically. default = true
	/// </summary>
	[DataMember(Name = "isAtomic")]
	public bool? IsAtomic { get; set; }

	/// <summary>
	/// List of networks and corresponding product types to update. Maximum 500 networks
	/// </summary>
	[DataMember(Name = "items")]
	public List<AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateRequestItem>? Items { get; set; }
}
