using Meraki.Api.Data;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IBillings
	{
		/// <summary>
		/// getNetworkWirelessBilling
		/// </summary>
		/// <remarks>
		/// Return the billing settings of this network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/billing")]
		Task<NetworkWirelessBilling> GetNetworkWirelessBilling(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// updateNetworkWirelessBilling
		/// </summary>
		/// <remarks>
		/// Update the billing settings
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkWirelessBilling"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/billing")]
		Task<NetworkWirelessBilling> UpdateNetworkWirelessBilling(
			[AliasAs("networkId")] string networkId,
			[Body]NetworkWirelessBilling updateNetworkWirelessBilling
			);
	}
}
