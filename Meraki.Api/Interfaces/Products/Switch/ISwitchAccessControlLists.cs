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
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchAccessControlLists")]
	[Get("/networks/{networkId}/switch/accessControlLists")]
	Task<SwitchAccessControlListRules> GetNetworkSwitchAccessControlListsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the access control lists for a MS network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkSwitchAccessControlLists"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkSwitchAccessControlLists")]
	[Put("/networks/{networkId}/switch/accessControlLists")]
	Task<SwitchAccessControlListRules> UpdateNetworkSwitchAccessControlListsAsync(
		string networkId,
		[Body] SwitchAccessControlListRules updateNetworkSwitchAccessControlLists,
		CancellationToken cancellationToken = default
		);
}
