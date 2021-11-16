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
	[ApiOperationId("getNetworkMerakiAuthUsers")]
	[Get("/networks/{networkId}/merakiAuthUsers")]
	Task<List<MerakiAuthUser>> GetNetworkMerakiAuthUsersAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Authorize a user configured with Meraki Authentication for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUser">Body for authorizing a meraki user</param>
	[ApiOperationId("createNetworkMerakiAuthUser")]
	[Post("/networks/{networkId}/merakiAuthUsers")]
	Task<MerakiAuthUser> CreateNetworkMerakiAuthUserAsync(
		[AliasAs("networkId")] string networkId,
		[Body] MerakiAuthUserCreateUpdateRequest merakiAuthUser,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the Meraki Auth splash guest, RADIUS, or client VPN user
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUserId">The meraki user id</param>
	[ApiOperationId("getNetworkMerakiAuthUser")]
	[Get("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
	Task<MerakiAuthUser> GetNetworkMerakiAuthUserAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Deauthorize a user
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUserId">The meraki user id</param>
	[ApiOperationId("deleteNetworkMerakiAuthUser")]
	[Delete("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
	Task DeleteNetworkMerakiAuthUserAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a user configured with Meraki Authentication
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUserId">The meraki user id</param>
	/// <param name="merakiAuthUser">Body for updating a user</param>
	[ApiOperationId("updateNetworkMerakiAuthUser")]
	[Put("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
	Task<MerakiAuthUser> UpdateNetworkMerakiAuthUserAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
		[Body] MerakiAuthUserCreateUpdateRequest merakiAuthUser,
		CancellationToken cancellationToken = default
		);

}
