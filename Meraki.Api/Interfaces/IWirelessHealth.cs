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
		/// Aggregated connectivity info for a given client on this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="clientId">The client ID (MAC)</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		[Get("/networks/{networkId}/wireless/clients/{clientId}/connectionStats")]
		Task<NetworkClientConnectionStats> GetNetworkClientConnectionStatsAsync(
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
		/// Aggregated latency info for a given client on this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
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
		[Get("/networks/{networkId}/wireless/clients/{clientId}/latencyStats")]
		Task<NetworkClientLatencyStats> GetNetworkClientLatencyStatsAsync(
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
		/// Aggregated connectivity info for this network, grouped by clients
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		[Get("/networks/{networkId}/wireless/clients/connectionStats")]
		Task<List<NetworkClientConnectionStats>> GetNetworkClientsConnectionStatsAsync(
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
		/// Aggregated latency info for this network, grouped by clients
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="fields">Partial selection: If present, this call will return only the selected fields of [\&quot;rawDistribution\&quot;, \&quot;avg\&quot;]. All fields will be returned by default. Selected fields must be entered as a comma separated string. (optional)</param>
		[Get("/networks/{networkId}/wireless/clients/latencyStats")]
		Task<List<NetworkClientLatencyStats>> GetNetworkClientsLatencyStatsAsync(
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
		/// Aggregated connectivity info for this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		[Get("/networks/{networkId}/wireless/connectionStats")]
		Task<ConnectionStats> GetNetworkConnectionStatsAsync(
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
		/// Aggregated connectivity info for a given AP on this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		[Get("/devices/{serial}/wireless/connectionStats")]
		Task<NetworkDeviceConnectionStats> GetNetworkDeviceConnectionStatsAsync(
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
		/// Aggregated latency info for a given AP on this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="fields">Partial selection: If present, this call will return only the selected fields of [\&quot;rawDistribution\&quot;, \&quot;avg\&quot;]. All fields will be returned by default. Selected fields must be entered as a comma separated string. (optional)</param>
		[Get("/devices/{serial}/wireless/latencyStats")]
		Task<NetworkDeviceLatencyStats> GetNetworkDeviceLatencyStatsAsync(
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
		/// Aggregated connectivity info for this network, grouped by node
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		[Get("/networks/{networkId}/wireless/devices/connectionStats")]
		Task<List<NetworkDeviceConnectionStats>> GetNetworkDevicesConnectionStatsAsync(
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
		/// Aggregated latency info for this network, grouped by node
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="fields">Partial selection: If present, this call will return only the selected fields of [\&quot;rawDistribution\&quot;, \&quot;avg\&quot;]. All fields will be returned by default. Selected fields must be entered as a comma separated string. (optional)</param>
		[Get("/networks/{networkId}/wireless/devices/latencyStats")]
		Task<List<NetworkDeviceLatencyStats>> GetNetworkDevicesLatencyStatsAsync(
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
		/// List of all failed client connection events on this network in a given time range
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="serial">Filter by AP (optional)</param>
		/// <param name="clientId">Filter by client MAC (optional)</param>
		[Get("/networks/{networkId}/wireless/failedConnections")]
		Task<List<FailedConnection>> GetNetworkFailedConnectionsAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("band")]string band = null!,
			[AliasAs("ssid")]int? ssid = null,
			[AliasAs("vlan")]int? vlan = null,
			[AliasAs("apTag")]string apTag = null!,
			[AliasAs("serial")]string serial = null!,
			[AliasAs("clientId")]string clientId = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Aggregated latency info for this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network ID</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="band">Filter results by band (either &#39;2.4&#39; or &#39;5&#39;). Note that data prior to February 2020 will not have band information. (optional)</param>
		/// <param name="ssid">Filter results by SSID (optional)</param>
		/// <param name="vlan">Filter results by VLAN (optional)</param>
		/// <param name="apTag">Filter results by AP Tag (optional)</param>
		/// <param name="fields">Partial selection: If present, this call will return only the selected fields of [\&quot;rawDistribution\&quot;, \&quot;avg\&quot;]. All fields will be returned by default. Selected fields must be entered as a comma separated string. (optional)</param>
		[Get("/networks/{networkId}/wireless/latencyStats")]
		Task<LatencyStats> GetNetworkLatencyStatsAsync(
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
		/// Aggregated latency info for this network, grouped by clients
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 180 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. (optional)</param>
		/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 300, 600, 1200, 3600, 14400, 86400. The default is 86400.</param>
		/// <param name="autoResolution">Automatically select a data resolution based on the given timespan; this overrides the value specified by the 'resolution' parameter. The default setting is false.</param>
		/// <param name="clientId">Filter results by network client.</param>
		/// <param name="deviceSerial">Filter results by device.</param>
		/// <param name="apTag">Filter results by AP tag.</param>
		/// <param name="band">Filter results by band (either '2.4' or '5').</param>
		/// <param name="ssid">Filter results by SSID number.</param>
		/// <param name="accessCategory">Filter by access category.</param>
		[Get("/networks/{networkId}/wireless/latencyHistory")]
		Task<List<LatencyHistory>> GetNetworkWirelessLatencyHistoryAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("t1")] string t1 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("resolution")] int? resolution = null,
			[AliasAs("autoResolution")] bool? autoResolution = null,
			[AliasAs("clientId")] string? clientId = null,
			[AliasAs("deviceSerial")] string? deviceSerial = null,
			[AliasAs("apTag")] string? apTag = null,	
			[AliasAs("band")] string? band = null,
			[AliasAs("ssid")] string? ssid = null,
			[AliasAs("accessCategory")] string? accessCategory = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Aggregated latency info for this network, grouped by clients
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 500. Default is 50.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		[Get("/networks/{networkId}/wireless/meshStatuses")]
		Task<List<LatencyHistory>> GetNetworkWirelessMeshStatusesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			CancellationToken cancellationToken = default);
	}
}