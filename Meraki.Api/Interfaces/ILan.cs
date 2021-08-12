using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface ILan
	{
		/// <summary>
		/// Return single LAN configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/singleLan")]
		Task<LanConfiguration> GetNetworkApplianceSingleLanAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update single LAN configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkApplianceSingleLan">Body for updating a single LAN config</param>
		[Put("/networks/{networkId}/appliance/singleLan")]
		Task<LanConfiguration> UpdateNetworkApplianceSingleLanAsync(
			[AliasAs("networkId")] string networkId,
			[Body]LanConfiguration UpdateNetworkApplianceSingleLan,
			CancellationToken cancellationToken = default
			);
	}
}
