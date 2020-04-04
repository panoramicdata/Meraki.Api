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
	public interface ISsids
	{
		/// <summary>
		/// getNetworkDeviceWirelessStatus
		/// </summary>
		/// <remarks>
		/// Return the SSID statuses of an access point
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/devices/{serial}/wireless/status")]
		Task<object> GetNetworkDeviceWirelessStatus(
			[AliasAs("networkId")]string networkId,
			[AliasAs("serial")]string serial
			);

		/// <summary>
		/// getNetworkSsid
		/// </summary>
		/// <remarks>
		/// Return a single SSID
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/ssids/{number}")]
		Task<NetworkSsid> GetAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkSsids
		/// </summary>
		/// <remarks>
		/// List the SSIDs in a network. Supports networks with access points or wireless-enabled security appliances and teleworker gateways.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/ssids")]
		Task<List<NetworkSsid>> GetAllAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkSsid
		/// </summary>
		/// <remarks>
		/// Update the attributes of an SSID
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="updateNetworkSsid"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/ssids/{number}")]
		Task<NetworkSsid> UpdateAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			[Body]UpdateNetworkSsid updateNetworkSsid,
			CancellationToken cancellationToken = default);
	}
}
