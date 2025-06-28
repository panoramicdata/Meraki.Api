namespace Meraki.Api.Data;

/// <summary>
/// Network
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponseItemNetwork
{
	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Product types
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productTypes")]
	public List<AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponseItemNetworkProductType> ProductTypes { get; set; } = [];
}
