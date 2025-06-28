namespace Meraki.Api.Data;

/// <summary>
/// Network that was successfully updated
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponseItem
{
	/// <summary>
	/// Network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponseItemNetwork Network { get; set; } = new();
}
