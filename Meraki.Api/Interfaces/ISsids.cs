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
		[Get("/devices/{serial}/wireless/status")]
		Task<object> GetNetworkDeviceWirelessStatus(
			[AliasAs("serial")]string serial
			);

		/// <summary>
		/// getNetworkSsid
		/// </summary>
		/// <remarks>
		/// Return a single MR SSID
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}")]
		Task<NetworkSsid> GetAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkSsids
		/// </summary>
		/// <remarks>
		/// List the MR SSIDs in a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids")]
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
		[Put("/networks/{networkId}/wireless/ssids/{number}")]
		Task<NetworkSsid> UpdateAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			[Body]SsidUpdateRequest updateNetworkSsid,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkWirelessSsidIdentityPsks
		/// </summary>
		/// <remarks>
		/// List all Identity PSKs in a wireless network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/identityPsks")]
		Task<List<IdentityPsks>> GetNetworkWirelessSsidIdentityPsks(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number
			);

		/// <summary>
		/// createNetworkWirelessSsidIdentityPsk
		/// </summary>
		/// <remarks>
		/// List all Identity PSKs in a wireless network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="createNetworkWirelessSsidIdentityPsk"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/wireless/ssids/{number}/identityPsks")]
		Task<IdentityPsks> CreateNetworkWirelessSsidIdentityPsk(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body]IdentityPsks createNetworkWirelessSsidIdentityPsk
			);

		/// <summary>
		/// getNetworkWirelessSsidIdentityPsk
		/// </summary>
		/// <remarks>
		/// Return an Identity PSK
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="identityPskId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
		Task<IdentityPsks> GetNetworkWirelessSsidIdentityPsk(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[AliasAs("identityPskId")] string identityPskId
			);

		/// <summary>
		/// updateNetworkWirelessSsidIdentityPsk
		/// </summary>
		/// <remarks>
		/// Update an Identity PSK
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="identityPskId"></param>
		/// <param name="updateNetworkWirelessSsidIdentityPsk"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
		Task<IdentityPsks> UpdateNetworkWirelessSsidIdentityPsk(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[AliasAs("identityPskId")] string identityPskId,
			[Body]IdentityPsks updateNetworkWirelessSsidIdentityPsk
			);

		/// <summary>
		/// deleteNetworkWirelessSsidIdentityPsk
		/// </summary>
		/// <remarks>
		/// Delete an Identity PSK
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="identityPskId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
		Task DeleteNetworkWirelessSsidIdentityPsk(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[AliasAs("identityPskId")] string identityPskId,
			CancellationToken cancellationToken = default);
	}
}
