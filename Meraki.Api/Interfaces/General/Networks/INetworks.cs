namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworks
{
	/// <summary>
	/// Return a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <returns>Task of Object</returns>
	[ApiOperationId("getNetwork")]
	[Get("/networks/{networkId}")]
	Task<Network> GetNetworkAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="networkUpdateRequest">Body for updating a network</param>
	[ApiOperationId("updateNetwork")]
	[Put("/networks/{networkId}")]
	Task<Network> UpdateNetworkAsync(
		[AliasAs("networkId")] string networkId,
		[Body] NetworkUpdateRequest networkUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("deleteNetwork")]
	[Delete("/networks/{networkId}")]
	Task DeleteNetworkAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Bind a network to a template.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="bindNetwork">Body for binding a network</param>
	[ApiOperationId("bindNetwork")]
	[Post("/networks/{networkId}/bind")]
	Task BindNetworkAsync(
		[AliasAs("networkId")] string networkId,
		[Body] ConfigurationTemplateBindRequest bindNetwork,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Split a combined network into individual networks for each type of device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("splitNetwork")]
	[Post("/networks/{networkId}/split")]
	Task<SplitNetworkResponse> SplitNetworkAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Unbind a network from a template.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("unbindNetwork")]
	[Post("/networks/{networkId}/unbind")]
	Task UnbindNetworkAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);
}
