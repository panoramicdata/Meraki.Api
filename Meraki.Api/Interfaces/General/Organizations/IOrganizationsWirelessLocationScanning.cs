namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Wireless Location Scanning
/// </summary>
public interface IOrganizationsWirelessLocationScanning
{
	/// <summary>
	/// Return scanning API settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessLocationScanningByNetwork")]
	[Get("/organizations/{organizationId}/wireless/location/scanning/byNetwork")]
	Task<WirelessLocationScanningByNetwork> GetOrganizationWirelessLocationScanningByNetworkAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return scanning API receivers
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessLocationScanningReceivers")]
	[Get("/organizations/{organizationId}/wireless/location/scanning/receivers")]
	Task<WirelessLocationScanningReceivers> GetOrganizationWirelessLocationScanningReceiversAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add new receiver for scanning API
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="wirelessReceiverCreateRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationWirelessLocationScanningReceiver")]
	[Post("/organizations/{organizationId}/wireless/location/scanning/receivers")]
	Task<WirelessReceiver> CreateOrganizationWirelessLocationScanningReceiverAsync(
		string organizationId,
		[Body] WirelessReceiverCreateRequest wirelessReceiverCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Change scanning API receiver settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="receiverId"></param>
	/// <param name="wirelessReceiverCreateRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationWirelessLocationScanningReceiver")]
	[Put("/organizations/{organizationId}/wireless/location/scanning/receivers/{receiverId}")]
	Task<WirelessReceiver> UpdateOrganizationWirelessLocationScanningReceiverAsync(
		string organizationId,
		string receiverId,
		[Body] WirelessReceiverUpdateRequest wirelessReceiverCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a scanning API receiver
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="receiverId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationWirelessLocationScanningReceiver")]
	[Delete("/organizations/{organizationId}/wireless/location/scanning/receivers/{receiverId}")]
	Task DeleteOrganizationWirelessLocationScanningReceiverAsync(
		string organizationId,
		string receiverId,
		CancellationToken cancellationToken = default
		);
}
