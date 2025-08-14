namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworks
{
	/// <summary>
	/// Return a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	/// <returns>Task of Object</returns>
	[ApiOperationId("getNetwork")]
	[Get("/networks/{networkId}")]
	Task<Network> GetNetworkAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="networkUpdateRequest">Body for updating a network</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetwork")]
	[Put("/networks/{networkId}")]
	Task<Network> UpdateNetworkAsync(
		string networkId,
		[Body] NetworkUpdateRequest networkUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteNetwork")]
	[Delete("/networks/{networkId}")]
	Task DeleteNetworkAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Bind a network to a template.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="configurationTemplateBindRequest">Body for binding a network to a template</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("bindNetwork")]
	[Post("/networks/{networkId}/bind")]
	Task BindNetworkAsync(
		string networkId,
		[Body] ConfigurationTemplateBindRequest configurationTemplateBindRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Split a combined network into individual networks for each type of device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("splitNetwork")]
	[Post("/networks/{networkId}/split")]
	Task<SplitNetworkResponse> SplitNetworkAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Unbind a network from a template.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="configurationTemplateUnbindRequest">Optional body for unbinding from a template.</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("unbindNetwork")]
	[Post("/networks/{networkId}/unbind")]
	Task<Network> UnbindNetworkAsync(
		string networkId,
		[Body] ConfigurationTemplateUnbindRequest configurationTemplateUnbindRequest,
		CancellationToken cancellationToken = default
		);
}