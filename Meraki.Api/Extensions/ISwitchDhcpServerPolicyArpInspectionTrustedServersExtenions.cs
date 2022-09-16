namespace Meraki.Api.Extensions;

public static class ISwitchDhcpServerPolicyArpInspectionTrustedServersExtenions
{
	/// <summary>
	/// Get All Arp Inspection Trusted Servers
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	public static Task<List<TrustedServer>> GetNetworkSwitchDhcpServerPolicyArpInspectionTrustedServersAllAsync(
		this ISwitchDhcpServerPolicyArpInspectionTrustedServers switchDhcpServerPolicyArpInspectionTrustedServer,
		string networkId,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> switchDhcpServerPolicyArpInspectionTrustedServer.GetNetworkSwitchDhcpServerPolicyArpInspectionTrustedServersApiResponseAsync(
						networkId,
						startingAfter,
						cancellationToken
					),
					cancellationToken
			);
}
