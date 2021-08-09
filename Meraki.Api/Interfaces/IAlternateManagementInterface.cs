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
	public interface IAlternateManagementInterface
	{
		/// <summary>
		/// getNetworkSwitchAlternateManagementInterface
		/// </summary>
		/// <remarks>
		/// Return the switch alternate management interface for the network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/alternateManagementInterface")]
		Task<AlternateManagementInterface> GetNetworkSwitchAlternateManagementInterface(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// updateNetworkSwitchAlternateManagementInterface
		/// </summary>
		/// <remarks>
		/// Update the switch alternate management interface for the network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/alternateManagementInterface")]
		Task<AlternateManagementInterface> UpdateNetworkSwitchAlternateManagementInterface(
			[AliasAs("networkId")] string networkId,
			[Body]AlternateManagementInterface updateNetworkSwitchAlternateManagementInterface
			);
	}
}
