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
	public interface IBluetoothClients
	{
		/// <summary>
		/// Return a Bluetooth client
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="bluetoothClientId">The bluetooth client id</param>
		/// <param name="includeConnectivityHistory">Include the connectivity history for this client (optional)</param>
		/// <param name="connectivityHistoryTimespan">The timespan, in seconds, for the connectivityHistory data. By default 1 day, 86400, will be used. (optional)</param>
		[Get("/networks/{networkId}/bluetoothClients/{bluetoothClientId}")]
		Task<BluetoothClient> GetAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("bluetoothClientId")]string bluetoothClientId,
			[AliasAs("includeConnectivityHistory")]bool? includeConnectivityHistory = null,
			[AliasAs("connectivityHistoryTimespan")]int? connectivityHistoryTimespan = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the Bluetooth clients seen by APs in this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 7 days from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 7 days. The default is 1 day. (optional)</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 5 - 1000. Default is 10. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="includeConnectivityHistory">Include the connectivity history for this client (optional)</param>
		[Get("/networks/{networkId}/bluetoothClients")]
		Task<List<BluetoothClient>> GetAllAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!,
			[AliasAs("includeConnectivityHistory")]bool? includeConnectivityHistory = null,
			CancellationToken cancellationToken = default);
	}
}
