namespace Meraki.Api.Interfaces.General.Devices;
public interface IDevicesWirelessZigbeeEnrollments
{
	/// <summary>
	/// Enqueue a job to start enrolling doorlocks on zigbee configured MRs
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// </summary>
	/// <param name="serial"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createDeviceWirelessZigbeeEnrollment")]
	[Post("/devices/{serial}/wireless/zigbee/enrollments")]
	Task<DevicesWirelessZigbeeEnrollments> CreateDeviceWirelessZigbeeEnrollmentAsync(string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return an enrollment job
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceWirelessZigbeeEnrollment")]
	[Get("/devices/{serial}/wireless/zigbee/enrollments/{id}")]
	Task<DevicesWirelessZigbeeEnrollmentsDetailed> GetDeviceWirelessZigbeeEnrollmentAsync(string serial,
	string id, CancellationToken cancellationToken = default);
}
