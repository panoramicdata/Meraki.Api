using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IFirewallRules
	{
		/// <summary>
		/// Return the L7 firewall rules for an SSID on an MR network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/firewall/l7FirewallRules")]
		Task<SsidL7FirewallRules> GetNetworkWirelessSsidFirewallL7FirewallRulesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the L7 firewall rules for an SSID on an MR network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="updateNetworkWirelessSsidFirewallL7FirewallRules">Body for updating L7 Firewall rules</param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/firewall/l7FirewallRules")]
		Task<SsidL7FirewallRules> UpdateNetworkWirelessSsidFirewallL7FirewallRulesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		[Body] SsidL7FirewallRules updateNetworkWirelessSsidFirewallL7FirewallRules,
		CancellationToken cancellationToken = default
			);
	}
}
