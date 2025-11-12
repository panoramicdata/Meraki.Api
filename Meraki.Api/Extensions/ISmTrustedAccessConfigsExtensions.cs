namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for ISm Truted Access Config
/// </summary>

public static class ISmTrutedAccessConfigExtensions
{
	/// <summary>
	/// List All Trusted Access Configs
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="smTrustedAccessConfigs"></param>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	public static Task<List<SmTrustedAccessConfig>> GetNetworkSmTrustedAccessConfigsAsync(
		this ISmTrustedAccessConfigs smTrustedAccessConfigs,
		string networkId,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> smTrustedAccessConfigs.GetNetworkSmTrustedAccessConfigsApiResponseAsync(
						networkId,
						startingAfter,
						endingBefore,
						cancellationToken
					),
					cancellationToken
			);
}
