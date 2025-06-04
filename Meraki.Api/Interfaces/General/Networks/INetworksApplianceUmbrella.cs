namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksApplianceUmbrella
{
	/// <summary>
	/// Connect to Cisco Umbrella account to this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("connectNetworkApplianceUmbrellaAccount")]
	[Post("/networks/{networkId}/appliance/umbrella/account/connect")]
	Task<NetworkUmbrellaAccountConnectResponse> ConnectNetworkApplianceUmbrellaAccountAsync(
		string networkId,
		[Body] NetworkUmbrellaAccountConnectRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Disconnect Umbrella account from this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("disconnectNetworkApplianceUmbrellaAccount")]
	[Delete("/networks/{networkId}/appliance/umbrella/account/disconnect")]
	Task<NetworkUmbrellaAccountDisconnectResponse> DisconnectNetworkApplianceUmbrellaAccountAsync(
		string networkId,
		CancellationToken cancellationToken = default
	);
}
