namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface INetworksMerakiAuthUsers
{
	/// <summary>
	/// Return the Meraki Auth splash guest, RADIUS, or client VPN user
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUserId">The meraki user id</param>
	[Get("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
	Task<MerakiAuthUser> GetAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a user configured with Meraki Authentication
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUserId">The meraki user id</param>
	/// <param name="merakiAuthUser">Body for updating a user</param>
	[Put("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
	Task<MerakiAuthUser> UpdateAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
		[Body] MerakiAuthUserCreateUpdateRequest merakiAuthUser,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the users configured under Meraki Authentication for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/merakiAuthUsers")]
	Task<List<MerakiAuthUser>> GetAllAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Authorize a user configured with Meraki Authentication for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUser">Body for authorizing a meraki user</param>
	[Post("/networks/{networkId}/merakiAuthUsers")]
	Task<MerakiAuthUser> CreateAsync(
		[AliasAs("networkId")] string networkId,
		[Body] MerakiAuthUserCreateUpdateRequest merakiAuthUser,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Deauthorize a user
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="merakiAuthUserId">The meraki user id</param>
	[Delete("/networks/{networkId}/merakiAuthUsers/{merakiAuthUserId}")]
	Task DeleteAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("merakiAuthUserId")] string merakiAuthUserId,
		CancellationToken cancellationToken = default);
}
