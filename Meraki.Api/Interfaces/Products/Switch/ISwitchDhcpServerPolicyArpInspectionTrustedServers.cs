namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Get Network Switch Dhcp Server Policy Arp Inspection Trusted Servers
/// </summary>
public interface ISwitchDhcpServerPolicyArpInspectionTrustedServers
{
	/// <summary>
	/// Return the list of servers trusted by Dynamic ARP Inspection on this network. These are also known as whitelisted snoop entries
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The Network ID</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	[Get("/networks/{networkId}/switch/dhcpServerPolicy/arpInspection/trustedServers")]
	Task<List<TrustedServer>> GetNetworkSwitchDhcpServerPolicyArpInspectionTrustedServersAsync(
		string networkId,
		int? perPage,
		string? startingAfter,
		string? endingBefore,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Used by ISwitchDhcpServerPolicyArpInspectionTrustedServersExtensions.GetNetworkSwitchDhcpServerPolicyArpInspectionTrustedServersAllAsync
	/// </summary>
	[Get("/networks/{networkId}/switch/dhcpServerPolicy/arpInspection/trustedServers")]
	internal Task<ApiResponse<List<TrustedServer>>> GetNetworkSwitchDhcpServerPolicyArpInspectionTrustedServersApiResponseAsync(
		string networkId,
		string? startingAfter,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Add a server to be trusted by Dynamic ARP Inspection on this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network ID</param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/switch/dhcpServerPolicy/arpInspection/trustedServers")]
	Task<TrustedServer> CreateNetworkSwitchDhcpServerPolicyArpInspectionTrustedServerAsync(
		string networkId,
		[Body] TrustedServerCreateRequest trustedServer,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a server that is trusted by Dynamic ARP Inspection on this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network ID</param>
	/// <param name="trustedServerId">The Trusted Server ID</param>
	/// <param name="cancellationToken"></param>
	[Put(" /networks/{networkId}/switch/dhcpServerPolicy/arpInspection/trustedServers/{trustedServerId}")]
	Task<TrustedServer> UpdateNetworkSwitchDhcpServerPolicyArpInspectionTrustedServerAsync(
		string networkId,
		string trustedServerId,
		[Body] TrustedServerUpdateRequest trustedServer,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Remove a server from being trusted by Dynamic ARP Inspection on this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="trustedServerId">The trusted server</param>
	[Delete("/networks/{networkId}/switch/dhcpServerPolicy/arpInspection/trustedServers/{trustedServerId}")]
	Task DeleteNetworkSwitchDhcpServerPolicyArpInspectionTrustedServer(
		string networkId,
		string trustedServerId,
		CancellationToken cancellationToken = default
		);
}
