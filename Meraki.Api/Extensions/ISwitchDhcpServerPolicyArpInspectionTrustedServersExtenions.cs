namespace Meraki.Api.Extensions;

public static class ISwitchDhcpServerPolicyArpInspectionTrustedServersExtenions
{
	/// <summary>
	/// Get All Arp Inspection Trusted Servers
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="switchDhcpServerPolicyArpInspectionTrustedServer"></param>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
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
