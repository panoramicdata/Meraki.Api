namespace Meraki.Api.Data;

/// <summary>
/// Network that failed to update and its error
/// </summary>
[DataContract]
public class AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponseError
{
	/// <summary>
	/// Errors with the network as a whole
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// Network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponseErrorNetwork Network { get; set; } = new();
}
