namespace Meraki.Api.Data;

/// <summary>
/// Administered Licensing Subscription Networks Feature Tiers Update Response.
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponse
{
	/// <summary>
	/// Networks that failed to update and their errors
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "errors")]
	public List<AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponseError> Errors { get; set; } = [];

	/// <summary>
	/// Successfully updated networks
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponseItem> Items { get; set; } = [];
}
