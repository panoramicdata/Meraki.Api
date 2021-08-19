using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IClients
	{
		/// <summary>
		/// List the clients of a device, up to a maximum of a month ago
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
		[Get("/devices/{serial}/clients")]
		Task<List<DeviceClient>> GetAllAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("timespan")] double? timespan = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the client associated with the given identifier
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clientId">The client id</param>
		[Get("/networks/{networkId}/clients/{clientId}")]
		Task<Client> GetAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clientId")] string clientId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the latency history for a client
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clientId">The client id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 791 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 791 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 791 days. The default is 1 day. (optional)</param>
		/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 86400. The default is 86400. (optional)</param>
		[Get("/networks/{networkId}/wireless/clients/{clientId}/latencyHistory")]
		Task<List<ClientLatencyHistory>> GetLatencyHistoryAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clientId")] string clientId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("t1")] string t1 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("resolution")] int? resolution = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the policy assigned to a client on the network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clientId">The client id</param>
		[Get("/networks/{networkId}/clients/{clientId}/policy")]
		Task<ClientPolicyUpdateRequest> GetPolicyAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clientId")] string clientId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the splash authorization for a client, for each SSID they've associated with through splash
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clientId">The client id</param>
		[Get("/networks/{networkId}/clients/{clientId}/splashAuthorizationStatus")]
		Task<ClientSplashAuthorizationStatusUpdateRequest> GetSplashAuthorizationStatusAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clientId")] string clientId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the client's network traffic data over time
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clientId">The client id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		[Get("/networks/{networkId}/clients/{clientId}/trafficHistory")]
		Task<List<ClientTrafficHistory>> GetTrafficHistoryAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clientId")] string clientId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string startingAfter = null!,
			[AliasAs("endingBefore")] string endingBefore = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the client's daily usage history
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clientId">The client id</param>
		[Get("/networks/{networkId}/clients/{clientId}/usageHistory")]
		Task<List<ClientUsageHistory>> GetUsageHistoryAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clientId")] string clientId,
			CancellationToken cancellationToken = default);

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
		[Get("/networks/{networkId}/clients")]
		Task<List<Client>> GetByNetworkAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string startingAfter = null!,
			[AliasAs("endingBefore")] string endingBefore = null!,
			[AliasAs("statuses")] string? statuses = null,
			[AliasAs("ip")] string? ip = null,
			[AliasAs("ip6")] string? ip6 = null,
			[AliasAs("ip6Local")] string? ip6Local = null,
			[AliasAs("mac")] string? mac = null,
			[AliasAs("os")] string? os = null,
			[AliasAs("description")] string? description = null,
			[AliasAs("recentDeviceConnections")] List<string>? recentDeviceConnections = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Provisions a client with a name and policy
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="ClientProvisionRequest">Body for provisioning a client</param>
		[Post("/networks/{networkId}/clients/provision")]
		Task<ClientProvisionRequest> ProvisionAsync(
			[AliasAs("networkId")] string networkId,
			[Body] ClientProvisionRequest ClientProvisionRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the policy assigned to a client on the network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clientId">The client id</param>
		/// <param name="ClientPolicyUpdateRequest">Body for updating client policy</param>
		[Put("/networks/{networkId}/clients/{clientId}/policy")]
		Task<ClientPolicyUpdateRequest> UpdatePolicyAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clientId")] string clientId,
			[Body] ClientPolicyUpdateRequest ClientPolicyUpdateRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update a client's splash authorization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clientId">The client id</param>
		/// <param name="UpdateNetworkClientSplashAuthorizationStatus">Body for updating client's splash authorization</param>
		[Put("/networks/{networkId}/clients/{clientId}/splashAuthorizationStatus")]
		Task<ClientSplashAuthorizationStatusUpdateRequest> UpdateSplashAuthorizationStatusAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clientId")] string clientId,
			[Body] ClientSplashAuthorizationStatusUpdateRequest UpdateNetworkClientSplashAuthorizationStatus,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the application usage data for clients. Usage data is in kilobytes.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clients">A list of client keys, MACs or IPs separated by comma.</param>
		/// <param name="ssidNumber">An SSID number to include. If not specified, eveusage histories application usagents for all SSIDs will be returned.</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
		[Get("/networks/{networkId}/clients/applicationUsage")]
		Task<List<ApplicationUsage>> GetNetworkClientsApplicationUsageAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clients")] string clients = null!,
			[AliasAs("ssidNumber")] int? ssidNumber = null,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string startingAfter = null!,
			[AliasAs("endingBefore")] string endingBefore = null!,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("t1")] string t1 = null!,
			[AliasAs("timespan")] double? timespan = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the usage histories for clients.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clients">A list of client keys, MACs or IPs separated by comma.</param>
		/// <param name="ssidNumber">An SSID number to include. If not specified, eveusage histories application usagents for all SSIDs will be returned.</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
		[Get("/networks/{networkId}/clients/usageHistories")]
		Task<List<ClientApplicationHistory>> GetNetworkClientsUsageHistoriesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clients")] string clients = null!,
			[AliasAs("ssidNumber")] int? ssidNumber = null,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string startingAfter = null!,
			[AliasAs("endingBefore")] string endingBefore = null!,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("t1")] string t1 = null!,
			[AliasAs("timespan")] double? timespan = null,
			CancellationToken cancellationToken = default);
	}
}
