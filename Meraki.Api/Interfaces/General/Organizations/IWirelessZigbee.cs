namespace Meraki.Api.Interfaces.General.Organizations;
public interface IWirelessZigbee
{
	/// <summary>
	/// Return list of Zigbee configs
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
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
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
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
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="organizationZigbeeDeviceUpdate"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
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
	/// <param name="organizationId"></param>
	/// <param name="organizationZigbeeDisenrollmentRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
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
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessZigbeeDisenrollment")]
	[Get("/organizations/{organizationId}/wireless/zigbee/disenrollments/{id}")]
	Task<OrganizationZigbeeDisenrollmentDetailed> GetOrganizationWirelessZigbeeDisenrollmentAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Return the list of doorlocks for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessZigbeeDoorLocks")]
	[Get("/organizations/{organizationId}/wireless/zigbee/doorLocks")]
	Task<List<OrganizationZigbeeDoorLockDetailed>> GetOrganizationWirelessZigbeeDoorLocksAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
