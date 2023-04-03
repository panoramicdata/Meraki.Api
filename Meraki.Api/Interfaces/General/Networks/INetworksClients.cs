namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksClients
{
	/// <summary>
	/// List the clients that have used this network in the timespan
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 10. (optional)</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="statuses">Filters clients based on status. Can be one of 'Online' or 'Offline'.</param>
	/// <param name="ip">Filters clients based on a partial or full match for the ip address field.</param>
	/// <param name="ip6">Filters clients based on a partial or full match for the ip6 address field.</param>
	/// <param name="ip6Local">Filters clients based on a partial or full match for the ip6Local address field.</param>
	/// <param name="mac">Filters clients based on a partial or full match for the mac address field.</param>
	/// <param name="os">Filters clients based on a partial or full match for the os (operating system) field.</param>
	/// <param name="description">Filters clients based on a partial or full match for the description field.</param>
	/// <param name="recentDeviceConnections">Filters clients based on recent connection type. Can be one of 'Wired' or 'Wireless'.</param>
	[ApiOperationId("getNetworkClients")]
	[Get("/networks/{networkId}/clients")]
	[QueryUriFormat(UriFormat.Unescaped)]
	Task<List<Client>> GetNetworkClientsAsync(
		string networkId,
		string t0 = null!,
		double? timespan = null,
		int? perPage = 1000,
		string startingAfter = null!,
		string endingBefore = null!,
		string? statuses = null,
		string? ip = null,
		string? ip6 = null,
		string? ip6Local = null,
		string? mac = null,
		string? os = null,
		string? description = null,
		[AliasAs("recentDeviceConnections[]")] List<string>? recentDeviceConnections = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return the client associated with the given identifier. Clients can be identified by a client key or either the MAC or IP depending on whether the network uses Track-by-IP.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="clientId">The client id</param>
	[ApiOperationId("getNetworkClient")]
	[Get("/networks/{networkId}/clients/{clientId}")]
	[QueryUriFormat(UriFormat.Unescaped)]
	Task<Client> GetNetworkClientAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("clientId")] string clientId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Provisions a client with a name and policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="clientProvisionRequest">Body for provisioning a client</param>
	[ApiOperationId("provisionNetworkClients")]
	[Post("/networks/{networkId}/clients/provision")]
	Task<ClientProvisionRequest> ProvisionNetworkClientsAsync(
		[AliasAs("networkId")] string networkId,
		[Body] ClientProvisionRequest clientProvisionRequest,
		CancellationToken cancellationToken = default);
}
