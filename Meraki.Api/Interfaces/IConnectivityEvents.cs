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
	public interface IConnectivityEvents
	{
		/// <summary>
		/// List the wireless connectivity events for a client within a network in the timespan.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="clientId">The client id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
		///	<param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
		/// <param name="types">A list of event types to include. If not specified, events of all types will be returned. Valid types are 'assoc', 'disassoc', 'auth', 'deauth', 'dns', 'dhcp', 'roam', 'connection' and/or 'sticky'.</param>
		/// <param name="includedSeverities">A list of severities to include. If not specified, events of all severities will be returned. Valid severities are 'good', 'info', 'warn' and/or 'bad'.</param>
		/// <param name="band">Filter results by band (either '2.4' or '5').</param>
		/// <param name="ssidNumber">An SSID number to include. If not specified, events for all SSIDs will be returned.</param>
		/// <param name="deviceSerial">Filter results by an AP's serial number.</param>
		[Get("/networks/{networkId}/wireless/clients/{clientId}/connectivityEvents")]
		Task<List<ConnectivityEvents>> GetNetworkWirelessClientConnectivityEventsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("clientId")] string clientId,
			[AliasAs("perPage")] int? perPage = 1000,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			[AliasAs("t0")] string? t0 = null,
			[AliasAs("t1")] string? t1 = null,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("types")] List<string>? types = null,
			[AliasAs("includedSeverities")] List<string>? includedSeverities = null,
			[AliasAs("band")] string? band = null,
			[AliasAs("ssidNumber")] int? ssidNumber = null,
			[AliasAs("deviceSerial")] string? deviceSerial = null,
			CancellationToken cancellationToken = default
			);
	}
}