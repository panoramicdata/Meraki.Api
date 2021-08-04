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
		/// getDeviceClients
		/// </summary>
		/// <remarks>
		/// List the clients of a device, up to a maximum of a month ago
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/clients")]
		Task<object> GeGetAllAsync(
			[AliasAs("serial")]string serial,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("timespan")]double? timespan = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClient
		/// </summary>
		/// <remarks>
		/// Return the client associated with the given identifier
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/clients/{clientId}")]
		Task<object> GetAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClientEvents
		/// </summary>
		/// <remarks>
		/// Return the events associated with this client. Clients can be identified by a client key or either the MAC or IP depending on whether the network uses Track-by-IP.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientId"></param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 100. Default is 100. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/clients/{clientId}/events")]
		Task<object> GetEventsAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClientLatencyHistory
		/// </summary>
		/// <remarks>
		/// Return the latency history for a client
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 791 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 791 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 791 days. The default is 1 day. (optional)</param>
		/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 86400. The default is 86400. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/clients/{clientId}/latencyHistory")]
		Task<object> GetLatencyHistoryAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("resolution")]int? resolution = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClientPolicy
		/// </summary>
		/// <remarks>
		/// Return the policy assigned to a client on the network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/clients/{clientId}/policy")]
		Task<object> GetPolicyAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClientSplashAuthorizationStatus
		/// </summary>
		/// <remarks>
		/// Return the splash authorization for a client, for each SSID they've associated with through splash
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/clients/{clientId}/splashAuthorizationStatus")]
		Task<object> GetSplashAuthorizationStatusAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClientTrafficHistory
		/// </summary>
		/// <remarks>
		/// Return the client's network traffic data over time
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientId"></param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/clients/{clientId}/trafficHistory")]
		Task<object> GetTrafficHistoryAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClientUsageHistory
		/// </summary>
		/// <remarks>
		/// Return the client's daily usage history
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/clients/{clientId}/usageHistory")]
		Task<object> GetUsageHistoryAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClients
		/// </summary>
		/// <remarks>
		/// List the clients that have used this network in the timespan
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 10. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/clients")]
		Task<List<Client>> GetByNetworkAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// provisionNetworkClients
		/// </summary>
		/// <remarks>
		/// Provisions a client with a name and policy
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientProvisionRequest"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/clients/provision")]
		Task<object> ProvisionAsync(
			[AliasAs("networkId")]string networkId,
			[Body]ClientProvisionRequest clientProvisionRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkClientPolicy
		/// </summary>
		/// <remarks>
		/// Update the policy assigned to a client on the network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientId"></param>
		/// <param name="clientPolicyUpdateRequest"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/clients/{clientId}/policy")]
		Task<object> UpdatePolicyAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			[Body]ClientPolicyUpdateRequest clientPolicyUpdateRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkClientSplashAuthorizationStatus
		/// </summary>
		/// <remarks>
		/// Update a client's splash authorization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientId"></param>
		/// <param name="updateNetworkClientSplashAuthorizationStatus"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/clients/{clientId}/splashAuthorizationStatus")]
		Task<object> UpdateSplashAuthorizationStatusAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			[Body]ClientSplashAuthorizationStatusUpdateRequest updateNetworkClientSplashAuthorizationStatus,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClientsApplicationUsage
		/// </summary>
		/// <remarks>
		/// Return the application usage data for clients. Usage data is in kilobytes. Clients can be identified by client keys or either the MACs or IPs depending on whether the network uses Track-by-IP.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clients">A list of client keys, MACs or IPs separated by comma.</param>
		/// <param name="ssidNumber">An SSID number to include. If not specified, eveusage histories application usagents for all SSIDs will be returned.</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/clients/applicationUsage")]
		Task<List<ApplicationUsage>> GetNetworkClientsApplicationUsage(
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
		/// getNetworkClientsUsageHistories
		/// </summary>
		/// <remarks>
		/// Return the usage histories for clients. Usage data is in kilobytes. Clients can be identified by client keys or either the MACs or IPs depending on whether the network uses Track-by-IP.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clients">A list of client keys, MACs or IPs separated by comma.</param>
		/// <param name="ssidNumber">An SSID number to include. If not specified, eveusage histories application usagents for all SSIDs will be returned.</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/clients/usageHistories")]
		Task<List<ClientUsageHistory>> GetNetworkClientsUsageHistories(
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
