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
	public interface IPiis
	{
		/// <summary>
		/// Submit a new delete or restrict processing PII request
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkPiiRequest">Body for creating a PII request</param>
		[Post("/networks/{networkId}/pii/requests")]
		Task<PiiResponse> CreateNetworkPiiRequestAsync(
			[AliasAs("networkId")]string networkId,
			[Body]PiiCreationRequest CreateNetworkPiiRequest,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a restrict processing PII request
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="requestId">The request id</param>
		[Delete("/networks/{networkId}/pii/requests/{requestId}")]
		Task DeleteNetworkPiiRequestAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("requestId")]string requestId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the keys required to access Personally Identifiable Information (PII) for a given identifier
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="username">The username of a Systems Manager user (optional)</param>
		/// <param name="email">The email of a network user account or a Systems Manager device (optional)</param>
		/// <param name="mac">The MAC of a network client device or a Systems Manager device (optional)</param>
		/// <param name="serial">The serial of a Systems Manager device (optional)</param>
		/// <param name="imei">The IMEI of a Systems Manager device (optional)</param>
		/// <param name="bluetoothMac">The MAC of a Bluetooth client (optional)</param>
		[Get("/networks/{networkId}/pii/piiKeys")]
		Task<PiiPiiKeys> GetNetworkPiiPiiKeysAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("username")]string username = null!,
			[AliasAs("email")]string email = null!,
			[AliasAs("mac")]string mac = null!,
			[AliasAs("serial")]string serial = null!,
			[AliasAs("imei")]string imei = null!,
			[AliasAs("bluetoothMac")]string bluetoothMac = null!,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a PII request
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="requestId">The request id</param>
		[Get("/networks/{networkId}/pii/requests/{requestId}")]
		Task<PiiResponse> GetNetworkPiiRequestAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("requestId")]string requestId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the PII requests for this network or organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/pii/requests")]
		Task<List<PiiResponse>> GetNetworkPiiRequestsAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Given a piece of Personally Identifiable Information (PII), return the Systems Manager device ID(s) associated with that identifier
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="username">The username of a Systems Manager user (optional)</param>
		/// <param name="email">The email of a network user account or a Systems Manager device (optional)</param>
		/// <param name="mac">The MAC of a network client device or a Systems Manager device (optional)</param>
		/// <param name="serial">The serial of a Systems Manager device (optional)</param>
		/// <param name="imei">The IMEI of a Systems Manager device (optional)</param>
		/// <param name="bluetoothMac">The MAC of a Bluetooth client (optional)</param>
		[Get("/networks/{networkId}/pii/smDevicesForKey")]
		Task<PiiSmKey> GetNetworkPiiSmDevicesForKeyAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("username")]string username = null!,
			[AliasAs("email")]string email = null!,
			[AliasAs("mac")]string mac = null!,
			[AliasAs("serial")]string serial = null!,
			[AliasAs("imei")]string imei = null!,
			[AliasAs("bluetoothMac")]string bluetoothMac = null!,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Given a piece of Personally Identifiable Information (PII), return the Systems Manager owner ID(s) associated with that identifier
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="username">The username of a Systems Manager user (optional)</param>
		/// <param name="email">The email of a network user account or a Systems Manager device (optional)</param>
		/// <param name="mac">The MAC of a network client device or a Systems Manager device (optional)</param>
		/// <param name="serial">The serial of a Systems Manager device (optional)</param>
		/// <param name="imei">The IMEI of a Systems Manager device (optional)</param>
		/// <param name="bluetoothMac">The MAC of a Bluetooth client (optional)</param>
		[Get("/networks/{networkId}/pii/smOwnersForKey")]
		Task<PiiSmKey> GetNetworkPiiSmOwnersForKeyAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("username")]string username = null!,
			[AliasAs("email")]string email = null!,
			[AliasAs("mac")]string mac = null!,
			[AliasAs("serial")]string serial = null!,
			[AliasAs("imei")]string imei = null!,
			[AliasAs("bluetoothMac")]string bluetoothMac = null!,
			CancellationToken cancellationToken = default);
	}
}
