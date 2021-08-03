using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IPiis
	{
		/// <summary>
		/// createNetworkPiiRequest
		/// </summary>
		/// <remarks>
		/// Submit a new delete or restrict processing PII request  ## ALTERNATE PATH  &#x60;&#x60;&#x60; /organizations/{organizationId}/pii/requests &#x60;&#x60;&#x60;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkPiiRequest"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/pii/requests")]
		Task<object> CreateNetworkPiiRequest(
			[AliasAs("networkId")]string networkId,
			[Body]PiiCreationRequest createNetworkPiiRequest
			);

		/// <summary>
		/// deleteNetworkPiiRequest
		/// </summary>
		/// <remarks>
		/// Delete a restrict processing PII request  ## ALTERNATE PATH  &#x60;&#x60;&#x60; /organizations/{organizationId}/pii/requests/{requestId} &#x60;&#x60;&#x60;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="requestId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/pii/requests/{requestId}")]
		Task DeleteNetworkPiiRequest(
			[AliasAs("networkId")]string networkId,
			[AliasAs("requestId")]string requestId
			);

		/// <summary>
		/// getNetworkPiiPiiKeys
		/// </summary>
		/// <remarks>
		/// List the keys required to access Personally Identifiable Information (PII) for a given identifier
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="username">The username of a Systems Manager user (optional)</param>
		/// <param name="email">The email of a network user account or a Systems Manager device (optional)</param>
		/// <param name="mac">The MAC of a network client device or a Systems Manager device (optional)</param>
		/// <param name="serial">The serial of a Systems Manager device (optional)</param>
		/// <param name="imei">The IMEI of a Systems Manager device (optional)</param>
		/// <param name="bluetoothMac">The MAC of a Bluetooth client (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/pii/piiKeys")]
		Task<object> GetNetworkPiiPiiKeys(
			[AliasAs("networkId")]string networkId,
			[AliasAs("username")]string username = null!,
			[AliasAs("email")]string email = null!,
			[AliasAs("mac")]string mac = null!,
			[AliasAs("serial")]string serial = null!,
			[AliasAs("imei")]string imei = null!,
			[AliasAs("bluetoothMac")]string bluetoothMac = null!
			);

		/// <summary>
		/// getNetworkPiiRequest
		/// </summary>
		/// <remarks>
		/// Return a PII request  ## ALTERNATE PATH  &#x60;&#x60;&#x60; /organizations/{organizationId}/pii/requests/{requestId} &#x60;&#x60;&#x60;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="requestId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/pii/requests/{requestId}")]
		Task<object> GetNetworkPiiRequest(
			[AliasAs("networkId")]string networkId,
			[AliasAs("requestId")]string requestId
			);

		/// <summary>
		/// getNetworkPiiRequests
		/// </summary>
		/// <remarks>
		/// List the PII requests for this network or organization  ## ALTERNATE PATH  &#x60;&#x60;&#x60; /organizations/{organizationId}/pii/requests &#x60;&#x60;&#x60;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/pii/requests")]
		Task<object> GetNetworkPiiRequests(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkPiiSmDevicesForKey
		/// </summary>
		/// <remarks>
		/// Given a piece of Personally Identifiable Information (PII), return the Systems Manager device ID(s) associated with that identifier
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="username">The username of a Systems Manager user (optional)</param>
		/// <param name="email">The email of a network user account or a Systems Manager device (optional)</param>
		/// <param name="mac">The MAC of a network client device or a Systems Manager device (optional)</param>
		/// <param name="serial">The serial of a Systems Manager device (optional)</param>
		/// <param name="imei">The IMEI of a Systems Manager device (optional)</param>
		/// <param name="bluetoothMac">The MAC of a Bluetooth client (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/pii/smDevicesForKey")]
		Task<object> GetNetworkPiiSmDevicesForKey(
			[AliasAs("networkId")]string networkId,
			[AliasAs("username")]string username = null!,
			[AliasAs("email")]string email = null!,
			[AliasAs("mac")]string mac = null!,
			[AliasAs("serial")]string serial = null!,
			[AliasAs("imei")]string imei = null!,
			[AliasAs("bluetoothMac")]string bluetoothMac = null!
			);

		/// <summary>
		/// getNetworkPiiSmOwnersForKey
		/// </summary>
		/// <remarks>
		/// Given a piece of Personally Identifiable Information (PII), return the Systems Manager owner ID(s) associated with that identifier
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="username">The username of a Systems Manager user (optional)</param>
		/// <param name="email">The email of a network user account or a Systems Manager device (optional)</param>
		/// <param name="mac">The MAC of a network client device or a Systems Manager device (optional)</param>
		/// <param name="serial">The serial of a Systems Manager device (optional)</param>
		/// <param name="imei">The IMEI of a Systems Manager device (optional)</param>
		/// <param name="bluetoothMac">The MAC of a Bluetooth client (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/pii/smOwnersForKey")]
		Task<object> GetNetworkPiiSmOwnersForKey(
			[AliasAs("networkId")]string networkId,
			[AliasAs("username")]string username = null!,
			[AliasAs("email")]string email = null!,
			[AliasAs("mac")]string mac = null!,
			[AliasAs("serial")]string serial = null!,
			[AliasAs("imei")]string imei = null!,
			[AliasAs("bluetoothMac")]string bluetoothMac = null!);
	}
}
