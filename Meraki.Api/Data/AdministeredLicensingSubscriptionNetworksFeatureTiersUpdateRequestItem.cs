namespace Meraki.Api.Data;

/// <summary>
/// Network and corresponding product types to update.
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateRequestItem
{
	/// <summary>
	/// Network
	/// </summary>
	[DataMember(Name = "network")]
	public AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateRequestItemNetwork? Network { get; set; }
}
