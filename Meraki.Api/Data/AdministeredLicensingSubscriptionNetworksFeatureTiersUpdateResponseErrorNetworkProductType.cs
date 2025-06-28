namespace Meraki.Api.Data;

/// <summary>
/// Product type
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponseErrorNetworkProductType
{
	/// <summary>
	/// Error message from feature tier update
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

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