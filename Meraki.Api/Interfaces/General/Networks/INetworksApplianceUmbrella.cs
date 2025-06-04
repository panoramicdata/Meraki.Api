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
	Task<NetworkUmbrellaAccountActionResponse> DisconnectNetworkApplianceUmbrellaAccountAsync(
		string networkId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Disable umbrella protection for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("disableNetworkApplianceUmbrellaProtection")]
	[Delete("/networks/{networkId}/appliance/umbrella/disableProtection")]
	Task<NetworkUmbrellaAccountActionResponse> DisableNetworkApplianceUmbrellaProtectionAsync(
		string networkId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Enable umbrella protection for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("enableNetworkApplianceUmbrellaProtection")]
	[Post("/networks/{networkId}/appliance/umbrella/enableProtection")]
	Task<NetworkUmbrellaAccountActionResponse> EnableNetworkApplianceUmbrellaProtectionAsync(
		string networkId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Specify one or more domain names to be excluded from being routed to Cisco Umbrella.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("excludeNetworkApplianceUmbrellaDomains")]
	[Post("/networks/{networkId}/appliance/umbrella/excludeDomains")]
	Task<NetworkUmbrellaAccountActionResponse> ExcludeNetworkApplianceUmbrellaDomainsAsync(
		string networkId,
		[Body] NetworkUmbrellaAccountExcludeDomainsRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Update umbrella policies applied to MX network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("policiesNetworkApplianceUmbrella")]
	[Put("/networks/{networkId}/appliance/umbrella/policies")]
	Task<NetworkUmbrellaAccountActionResponse> PoliciesNetworkApplianceUmbrellaAsync(
		string networkId,
		[Body] NetworkUmbrellaAccountPoliciesRequest request,
		CancellationToken cancellationToken = default
	);
}
