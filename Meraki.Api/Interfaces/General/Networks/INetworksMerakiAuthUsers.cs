namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface INetworksMerakiAuthUsers
{
	/// <summary>
	/// List the users configured under Meraki Authentication for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkMerakiAuthUsers")]
	[Get("/networks/{networkId}/merakiAuthUsers")]
	Task<List<MerakiAuthUser>> GetNetworkMerakiAuthUsersAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Authorize a user configured with Meraki Authentication for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUser">Body for authorizing a meraki user</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createNetworkMerakiAuthUser")]
	[Post("/networks/{networkId}/merakiAuthUsers")]
	Task<MerakiAuthUser> CreateNetworkMerakiAuthUserAsync(
		string networkId,
		[Body] MerakiAuthUserCreateUpdateRequest merakiAuthUser,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the Meraki Auth splash guest, RADIUS, or client VPN user
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUserId">The meraki user id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkMerakiAuthUser")]
	[Get("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
	Task<MerakiAuthUser> GetNetworkMerakiAuthUserAsync(
		string networkId,
		string merakiAuthUserId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Deauthorize a user
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUserId">The meraki user id</param>
	/// <param name="delete">If the ID supplied is for a splash guest or client VPN user, and that user is not authorized for any other networks in the organization, then also delete the user. 802.1X RADIUS users are always deleted regardless of this optional attribute.</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteNetworkMerakiAuthUser")]
	[Delete("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
	Task DeleteNetworkMerakiAuthUserAsync(
		string networkId,
		string merakiAuthUserId,
#pragma warning disable CA1716 // Identifiers should not match keywords - This is the name of the API parameter so no choice
		bool delete,
#pragma warning restore CA1716 // Identifiers should not match keywords
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a user configured with Meraki Authentication
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUserId">The meraki user id</param>
	/// <param name="merakiAuthUser">Body for updating a user</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkMerakiAuthUser")]
	[Put("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
	Task<MerakiAuthUser> UpdateNetworkMerakiAuthUserAsync(
		string networkId,
		string merakiAuthUserId,
		[Body] MerakiAuthUserCreateUpdateRequest merakiAuthUser,
		CancellationToken cancellationToken = default
		);
}
