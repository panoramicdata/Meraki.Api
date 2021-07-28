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
		/// getNetworkApplianceSingleLan
		/// </summary>
		/// <remarks>
		/// Return single LAN configuration
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/singleLan")]
		Task<LanConfiguration> GetNetworkApplianceSingleLan(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// updateNetworkApplianceSingleLan
		/// </summary>
		/// <remarks>
		/// Update single LAN configuration
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkApplianceSingleLan"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/singleLan")]
		Task<LanConfiguration> UpdateNetworkApplianceSingleLan(
			[AliasAs("networkId")] string networkId,
			[Body]LanConfiguration updateNetworkApplianceSingleLan
			);
	}
}
