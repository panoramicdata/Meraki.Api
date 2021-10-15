using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IFirewalls
	{
		/// <summary>
		/// Return the cellular firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/cellularFirewallRules")]
		Task<CellularFirewallRules> GetCellularFirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the cellular firewall rules of an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="mxCellularFirewallRules">Body for updating network cellular firewall rules</param>
		[Put("/networks/{networkId}/appliance/firewall/cellularFirewallRules")]
		Task<CellularFirewallRules> UpdateCellularFirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] CellularFirewallRules mxCellularFirewallRules,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the appliance services and their accessibility rules
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/firewalledServices")]
		Task<List<FirewalledService>> GetFirewalledServicesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the accessibility settings of the given service
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="serviceType">The serviceType</param>
		[Get("/networks/{networkId}/appliance/firewall/firewalledServices/{service}")]
		Task<List<FirewalledService>> GetFirewalledServiceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("service")] FirewalledServiceType serviceType,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Updates the accessibility settings for the given service
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="serviceType">The serviceType</param>
		[Put("/networks/{networkId}/appliance/firewall/firewalledServices/{service}")]
		Task<List<FirewalledService>> UpdateFirewalledServiceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("service")] FirewalledServiceType serviceType,
			[Body] FirewalledService service,
			CancellationToken cancellationToken = default
			);
	}
}
