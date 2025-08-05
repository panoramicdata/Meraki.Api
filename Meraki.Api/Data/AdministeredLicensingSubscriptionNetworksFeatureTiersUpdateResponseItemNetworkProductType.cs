namespace Meraki.Api.Data;

/// <summary>
/// Product type
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponseItemNetworkProductType
{
	/// <summary>
	/// Feature tier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "featureTier")]
	public FeatureTier FeatureTier { get; set; }

	/// <summary>
	/// Product type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public ProductType ProductType { get; set; }
}