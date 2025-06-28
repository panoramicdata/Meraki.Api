namespace Meraki.Api.Data;

/// <summary>
/// Network
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateRequestItemNetwork
{
	/// <summary>
	/// Network ID
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Product types
	/// </summary>
	[DataMember(Name = "productTypes")]
	public List<AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateRequestItemNetworkProductType> ProductTypes { get; set; } = [];
}
