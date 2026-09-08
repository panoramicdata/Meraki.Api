namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for switch DHCP server policy ARP inspection trusted servers
/// </summary>
public static class ISwitchDhcpServerPolicyArpInspectionTrustedServersExtenions
{
	/// <summary>
	/// Get All Arp Inspection Trusted Servers
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="switchDhcpServerPolicyArpInspectionTrustedServer"></param>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<TrustedServer>> GetNetworkSwitchDhcpServerPolicyArpInspectionTrustedServersAllAsync(
		this ISwitchDhcpServerPolicyArpInspectionTrustedServers switchDhcpServerPolicyArpInspectionTrustedServer,
		string networkId,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> switchDhcpServerPolicyArpInspectionTrustedServer.GetNetworkSwitchDhcpServerPolicyArpInspectionTrustedServersApiResponseAsync(
						networkId,
						startingAfter,
						endingBefore,
						cancellationToken
					),
					cancellationToken
			);
}
