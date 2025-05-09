namespace Meraki.Api.Interfaces.General.Organizations;

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
}
