namespace Meraki.Api.Interfaces.SecureConnect.Deployments;

public interface ISecureConnectDeploymentsOrganizationTunnel
{
	/// <summary>
	/// List the tunnels for an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="includeState">Specify whether to include the tunnel state information in the response. default = false</param>
	/// <param name="limit">The number of items to return in the collection. If not set, all tunnels are returned.</param>
	/// <param name="startKey">Specify where to start reading in the tunnel collection (startKey correlates to the first tunnel to return). If the startKey query parameter is not included in the API request, Umbrella reads the collection from the first available tunnel. When the API request includes the limit query parameter and you have more tunnels to read, Umbrella returns the value of startKey for the next tunnel in the hypermedia Link header.</param>
	/// <param name="filters">Filters the tunnel list by tunnel name, device type, service type, status, data center, or site origin ID.For example:{"name": "test","deviceType": "ISR","serviceType": "SIG","status": "UP","dataCenter": "pao1.edc","siteOriginId": 123}</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("listTunnels")]
	[Get("/organizations/{organizationId}/tunnels")]
	Task<List<SecureConnectTunnel>> ListTunnelsAsync(
		long organizationId,
		bool? includeState,
		int? limit,
		string? startKey,
		string? filters,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Add a new tunnel to the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="secureConnectTunnelCreateRequest">The tunnel to create.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("addTunnel")]
	[Post("/organizations/{organizationId}/tunnels")]
	Task<SecureConnectTunnel> AddTunnelAsync(
		long organizationId,
		[Body] SecureConnectTunnelCreateRequest secureConnectTunnelCreateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get a specific tunnel.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="id">The ID of the tunnel.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("getTunnel")]
	[Get("/organizations/{organizationId}/tunnels/{id}")]
	Task<SecureConnectTunnel> GetTunnelAsync(
		long organizationId,
		int id,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a tunnel in the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="id">The ID of the tunnel.</param>
	/// <param name="secureConnectTunnelDeleteRequest">Provide the tunnel to delete.y</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("deleteTunnel")]
	[Delete("/organizations/{organizationId}/tunnels/{id}")]
	Task DeleteTunnelAsync(
		long organizationId,
		int id,
		[Body] SecureConnectTunnelDeleteRequest? secureConnectTunnelDeleteRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the policies that include the network tunnel.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="id">The ID of the tunnel.</param>
	/// <param name="type">Filter the list of policies to only include the specified type. enum = ["firewallrule", "web"]</param>
	/// <param name="limit">The number of items to return in the collection.</param>
	/// <param name="page">The number of a page in the collection. Use with the limit parameter to implement pagination.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("getTunnelPolicies")]
	[Get("/organizations/{organizationId}/tunnels/{id}/policies")]
	Task<List<SecureConnectTunnelPolicy>> GetTunnelPoliciesAsync(
		long organizationId,
		int id,
		string? type,
		int? limit,
		int? page,
		CancellationToken cancellationToken = default);
}
