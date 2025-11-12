namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Sdwan Internet Policies
/// </summary>
public interface IApplianceSdwanInternetPolicies
{
	/// <summary>
	/// Update SDWAN internet traffic preferences for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="applianceSdwanInternetPoliciesUpdate">The update request body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceSdwanInternetPolicies")]
	[Put("/networks/{networkId}/appliance/sdwan/internetPolicies")]
	Task<List<SecurityEvent>> UpdateNetworkApplianceSdwanInternetPoliciesAsync(
		string networkId,
		[Body] ApplianceSdwanInternetPoliciesUpdate applianceSdwanInternetPoliciesUpdate,
		CancellationToken cancellationToken = default
		);
}
