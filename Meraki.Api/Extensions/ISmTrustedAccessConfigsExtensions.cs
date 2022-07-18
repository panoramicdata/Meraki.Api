﻿namespace Meraki.Api.Extensions;

public static class ISmTrutedAccessConfigExtensions
{
	/// <summary>
	/// List All Trusted Access Configs
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	public static Task<List<SmTrustedAccessConfig>> GetNetworkSmTrustedAccessConfigsAsync(
		this ISmTrustedAccessConfigs smTrustedAccessConfigs,
		string networkId,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> smTrustedAccessConfigs.GetNetworkSmTrustedAccessConfigsApiResponseAsync(
						networkId,
						startingAfter,
						cancellationToken
					),
					cancellationToken
			);
}
