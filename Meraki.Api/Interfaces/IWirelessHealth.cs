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
	public interface IWirelessHealth
	{
		/// <summary>
		/// getNetworkClientConnectionStats
		/// </summary>
		/// <remarks>
		/// Aggregated connectivity info for a given client on this network. Clients are identified by their MAC.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="clientId">The client ID (MAC)</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <returns>Task of NetworkClientConnectionStats</returns>
		[Get("/networks/{networkId}/clients/{clientId}/connectionStats")]
		Task<NetworkClientConnectionStats> GetNetworkClientConnectionStats(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClientLatencyStats
		/// </summary>
		/// <remarks>
		/// Aggregated latency info for a given client on this network. Clients are identified by their MAC.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="clientId">The client ID (MAC)</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="fields">Partial selection: If present, this call will return only the selected fields of [\&quot;rawDistribution\&quot;, \&quot;avg\&quot;]. All fields will be returned by default. Selected fields must be entered as a comma separated string. (optional)</param>
		/// <returns>Task of NetworkClientLatencyStats</returns>
		[Get("/networks/{networkId}/clients/{clientId}/latencyStats")]
		Task<NetworkClientLatencyStats> GetNetworkClientLatencyStats(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			[AliasAs("fields")]string fields = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClientsConnectionStats
		/// </summary>
		/// <remarks>
		/// Aggregated connectivity info for this network, grouped by clients
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <returns>Task of List of NetworkClientConnectionStats</returns>
		[Get("/networks/{networkId}/clients/connectionStats")]
		Task<List<NetworkClientConnectionStats>> GetNetworkClientsConnectionStats(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkClientsLatencyStats
		/// </summary>
		/// <remarks>
		/// Aggregated latency info for this network, grouped by clients
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="fields">Partial selection: If present, this call will return only the selected fields of [\&quot;rawDistribution\&quot;, \&quot;avg\&quot;]. All fields will be returned by default. Selected fields must be entered as a comma separated string. (optional)</param>
		/// <returns>Task of List of NetworkClientLatencyStats</returns>
		[Get("/networks/{networkId}/clients/latencyStats")]
		Task<List<NetworkClientLatencyStats>> GetNetworkClientsLatencyStats(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			[AliasAs("fields")]string fields = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkConnectionStats
		/// </summary>
		/// <remarks>
		/// Aggregated connectivity info for this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <returns>Task of ConnectionStats</returns>
		[Get("/networks/{networkId}/connectionStats")]
		Task<ConnectionStats> GetNetworkConnectionStats(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkDeviceConnectionStats
		/// </summary>
		/// <remarks>
		/// Aggregated connectivity info for a given AP on this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="serial">The serial number</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <returns>Task of NetworkDeviceConnectionStats</returns>
		[Get("/networks/{networkId}/devices/{serial}/connectionStats")]
		Task<NetworkDeviceConnectionStats> GetNetworkDeviceConnectionStats(
			[AliasAs("networkId")]string networkId,
			[AliasAs("serial")]string serial,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkDeviceLatencyStats
		/// </summary>
		/// <remarks>
		/// Aggregated latency info for a given AP on this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="serial">The serial number</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="fields">Partial selection: If present, this call will return only the selected fields of [\&quot;rawDistribution\&quot;, \&quot;avg\&quot;]. All fields will be returned by default. Selected fields must be entered as a comma separated string. (optional)</param>
		/// <returns>Task of NetworkDeviceLatencyStats</returns>
		[Get("/networks/{networkId}/devices/{serial}/latencyStats")]
		Task<NetworkDeviceLatencyStats> GetNetworkDeviceLatencyStats(
			[AliasAs("networkId")]string networkId,
			[AliasAs("serial")]string serial,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			[AliasAs("fields")]string fields = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkDevicesConnectionStats
		/// </summary>
		/// <remarks>
		/// Aggregated connectivity info for this network, grouped by node
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <returns>Task of List of NetworkDeviceConnectionStats</returns>
		[Get("/networks/{networkId}/devices/connectionStats")]
		Task<List<NetworkDeviceConnectionStats>> GetNetworkDevicesConnectionStats(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkDevicesLatencyStats
		/// </summary>
		/// <remarks>
		/// Aggregated latency info for this network, grouped by node
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="fields">Partial selection: If present, this call will return only the selected fields of [\&quot;rawDistribution\&quot;, \&quot;avg\&quot;]. All fields will be returned by default. Selected fields must be entered as a comma separated string. (optional)</param>
		/// <returns>Task of List of NetworkDeviceLatencyStats</returns>
		[Get("/networks/{networkId}/devices/latencyStats")]
		Task<List<NetworkDeviceLatencyStats>> GetNetworkDevicesLatencyStats(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			[AliasAs("fields")]string fields = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkFailedConnections
		/// </summary>
		/// <remarks>
		/// List of all failed client connection events on this network in a given time range
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="serial">Filter by AP (optional)</param>
		/// <param name="clientId">Filter by client MAC (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/failedConnections")]
		Task<object> GetNetworkFailedConnections(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			[AliasAs("serial")]string serial = null!,
			[AliasAs("clientId")]string clientId = null!);

		/// <summary>
		/// getNetworkLatencyStats
		/// </summary>
		/// <remarks>
		/// Aggregated latency info for this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="fields">Partial selection: If present, this call will return only the selected fields of [\&quot;rawDistribution\&quot;, \&quot;avg\&quot;]. All fields will be returned by default. Selected fields must be entered as a comma separated string. (optional)</param>
		/// <returns>Task of LatencyStats</returns>
		[Get("/networks/{networkId}/latencyStats")]
		Task<LatencyStats> GetNetworkLatencyStats(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			[AliasAs("fields")]string fields = null!,
			CancellationToken cancellationToken = default);
	}
}
