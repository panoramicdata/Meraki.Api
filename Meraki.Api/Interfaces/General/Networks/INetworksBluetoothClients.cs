namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface INetworksBluetoothClients
{
	/// <summary>
	/// Return a Bluetooth client
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="bluetoothClientId">The bluetooth client id</param>
	/// <param name="includeConnectivityHistory">Include the connectivity history for this client (optional)</param>
	/// <param name="connectivityHistoryTimespan">The timespan, in seconds, for the connectivityHistory data. By default 1 day, 86400, will be used. (optional)</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkBluetoothClient")]
	[Get("/networks/{networkId}/bluetoothClients/{bluetoothClientId}")]
	Task<BluetoothClient> GetNetworkBluetoothClientAsync(
		string networkId,
		string bluetoothClientId,
		bool? includeConnectivityHistory = null,
		int? connectivityHistoryTimespan = null,
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
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkBluetoothClients")]
	[Get("/networks/{networkId}/bluetoothClients")]
	Task<List<BluetoothClient>> GetNetworkBluetoothClientsAsync(
		string networkId,
		string t0 = null!,
		double? timespan = null,
		int? perPage = 1000,
		string startingAfter = null!,
		string endingBefore = null!,
		bool? includeConnectivityHistory = null,
		CancellationToken cancellationToken = default);
}
