namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessZigbee
{
	/// <summary>
	/// Return list of Zigbee configs
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationWirelessZigbeeByNetwork")]
	[Get("/organizations/{organizationId}/wireless/zigbee/byNetwork")]
	Task<List<OrganizationZigbeeConfiguration>> GetOrganizationZigbeesByNetworkAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// List the Zigbee MR Nodes for and organization or the supplied network(s)
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationWirelessZigbeeDevices")]
	[Get("/organizations/{organizationId}/wireless/zigbee/devices")]
	Task<List<OrganizationZigbeeDevice>> GetOrganizationZigbeeDevicesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Endpoint to update zigbee gateways
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="id">ID</param>
	/// <param name="organizationZigbeeDeviceUpdate">The request body</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("updateOrganizationWirelessZigbeeDevice")]
	[Put("/organizations/{organizationId}/wireless/zigbee/devices/{id}")]
	Task<OrganizationZigbeeDevice> UpdateOrganizationZigbeeDeviceAsync(
		string organizationId,
		string id,
		[Body] OrganizationZigbeeDeviceUpdateRequest organizationZigbeeDeviceUpdate,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Enqueue a job to start disenrolling doorlocks on zigbee configured MRs
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="organizationZigbeeDisenrollmentRequest">The request body</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("createOrganizationWirelessZigbeeDisenrollment")]
	[Post("/organizations/{organizationId}/wireless/zigbee/disenrollments")]
	Task<OrganizationZigbeeDisenrollment> CreateOrganizationWirelessZigbeeDisenrollmentAsync(
		string organizationId,
		[Body] OrganizationZigbeeDisenrollmentRequest organizationZigbeeDisenrollmentRequest,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Return a disenrollment job
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="disenrollmentId">Disenrollment ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationWirelessZigbeeDisenrollment")]
	[Get("/organizations/{organizationId}/wireless/zigbee/disenrollments/{disenrollmentId}")]
	Task<OrganizationZigbeeDisenrollmentDetailed> GetOrganizationWirelessZigbeeDisenrollmentAsync(
		string organizationId,
		string disenrollmentId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Return the list of doorlocks for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationWirelessZigbeeDoorLocks")]
	[Get("/organizations/{organizationId}/wireless/zigbee/doorLocks")]
	Task<List<OrganizationZigbeeDoorLockDetailed>> GetOrganizationWirelessZigbeeDoorLocksAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Endpoint to bulk update door locks params
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="doorlockId">Door Lock ID</param>
	/// <param name="organizationZigbeeDoorLockUpdateRequest">The update request</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("updateOrganizationWirelessZigbeeDoorLock")]
	[Put("/organizations/{organizationId}/wireless/zigbee/doorLocks/{doorlockId}")]
	Task<OrganizationZigbeeDoorLockDetailed> UpdateOrganizationWirelessZigbeeDoorLockAsync(
		string organizationId,
		string doorlockId,
		[Body] OrganizationZigbeeDoorLockUpdateRequest organizationZigbeeDoorLockUpdateRequest,
		CancellationToken cancellationToken = default
	);
}
