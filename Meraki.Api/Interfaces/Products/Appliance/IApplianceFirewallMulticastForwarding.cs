namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceFirewallMulticastForwarding
{
	/// <summary>
	/// List Static Multicasting forwarding settings for MX networks
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="networkIds">Optional parameter to filter the results by network IDs</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("getOrganizationApplianceFirewallMulticastForwardingByNetwork")]
	[Get("/organizations/{organizationId}/appliance/firewall/multicastForwarding/byNetwork")]
	Task<MulticastForwardingByNetwork> GetOrganizationApplianceFirewallMulticastForwardingByNetworkAsync(
		string organizationId,
		int? perPage = null,
		string? startingAfter = null,
		string? endingBefore = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update static multicast forward rules for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">Network ID</param>
	/// <param name="multicastForwardingByNetworkRules">Static multicast forwarding rules. Pass an empty array to clear all rules.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("updateNetworkApplianceFirewallMulticastForwarding")]
	[Put("/networks/{networkId}/appliance/firewall/multicastForwarding")]
	Task<MulticastForwardingByNetworkItem> UpdateNetworkApplianceFirewallMulticastForwardingAsync(
		string? networkId,
		[Body] List<MulticastForwardingByNetworkItemRule> multicastForwardingByNetworkRules,
		CancellationToken cancellationToken = default
		);
}
