namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchAccessControlLists
{
	/// <summary>
	/// Return the access control lists for a MS network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchAccessControlLists")]
	[Get("/networks/{networkId}/switch/accessControlLists")]
	Task<SwitchAccessControlListRules> GetNetworkSwitchAccessControlListsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the access control lists for a MS network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkSwitchAccessControlLists"></param>
	[ApiOperationId("updateNetworkSwitchAccessControlLists")]
	[Put("/networks/{networkId}/switch/accessControlLists")]
	Task<SwitchAccessControlListRules> UpdateNetworkSwitchAccessControlListsAsync(
		[AliasAs("networkId")] string networkId,
		[Body] SwitchAccessControlListRules updateNetworkSwitchAccessControlLists,
		CancellationToken cancellationToken = default
		);
}
