using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IFirewallRules
	{
		/// <summary>
		/// getNetworkWirelessSsidFirewallL7FirewallRules
		/// </summary>
		/// <remarks>
		/// Return the L7 firewall rules for an SSID on an MR network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/firewall/l7FirewallRules")]
		Task<SsidL7FirewallRules> GetNetworkWirelessSsidFirewallL7FirewallRules(
		[AliasAs("networkId")]string networkId,
		[AliasAs("number")]string number
			);

		/// <summary>
		/// updateNetworkWirelessSsidFirewallL7FirewallRules
		/// </summary>
		/// <remarks>
		/// Return the L7 firewall rules for an SSID on an MR network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="updateNetworkWirelessSsidFirewallL7FirewallRules"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/ssids/{number}/firewall/l7FirewallRules")]
		Task<SsidL7FirewallRules> UpdateNetworkWirelessSsidFirewallL7FirewallRules(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		[Body]SsidL7FirewallRules updateNetworkWirelessSsidFirewallL7FirewallRules
			);
	}
}
