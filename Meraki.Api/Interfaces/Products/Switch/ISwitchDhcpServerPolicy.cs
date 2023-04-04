namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchDhcpServerPolicy
{
	/// <summary>
	/// Return the DHCP server policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchDhcpServerPolicy")]
	[Get("/networks/{networkId}/switch/dhcpServerPolicy")]
	Task<DhcpServerPolicy> GetNetworkSwitchDhcpServerPolicyAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the DHCP server policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkSwitchSettingsDhcpServerPolicy"></param>
	[ApiOperationId("updateNetworkSwitchDhcpServerPolicy")]
	[Put("/networks/{networkId}/switch/dhcpServerPolicy")]
	Task<DhcpServerPolicy> UpdateNetworkSwitchDhcpServerPolicyAsync(
		string networkId,
		[Body] DhcpServerPolicy updateNetworkSwitchSettingsDhcpServerPolicy,
		CancellationToken cancellationToken = default
		);
}
