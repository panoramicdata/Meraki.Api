using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IFirewalledServices
	{
		/// <summary>
		/// List the appliance services and their accessibility rules
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/firewalledServices")]
		Task<List<FirewalledService>> GetNetworkFirewalledServicesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);
	}
}
