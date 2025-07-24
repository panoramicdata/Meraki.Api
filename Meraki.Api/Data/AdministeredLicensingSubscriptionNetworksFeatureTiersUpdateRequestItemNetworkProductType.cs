namespace Meraki.Api.Data;

/// <summary>
/// Product type
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateRequestItemNetworkProductType
{
	/// <summary>
	/// Feature tier
	/// </summary>
	[DataMember(Name = "featureTier")]
	public FeatureTier FeatureTier { get; set; }

	/// <summary>
	/// Product type
	/// </summary>
	[DataMember(Name = "productType")]
	public ProductType ProductType { get; set; }
}
