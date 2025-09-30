namespace Meraki.Api.Interfaces.General.Devices;
public interface IDevicesWirelessZigbeeEnrollments
{
	/// <summary>
	/// Enqueue a job to start enrolling doorlocks on zigbee configured MRs
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// </summary>
	/// <param name="serial"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createDeviceWirelessZigbeeEnrollment")]
	[Post("/devices/{serial}/wireless/zigbee/enrollments")]
	Task<DevicesWirelessZigbeeEnrollments> CreateDeviceWirelessZigbeeEnrollmentAsync(
		string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return an enrollment
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">Serial</param>
	/// <param name="enrollmentId">Enrollment ID</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceWirelessZigbeeEnrollment")]
	[Get("/devices/{serial}/wireless/zigbee/enrollments/{enrollmentId}")]
	Task<DevicesWirelessZigbeeEnrollmentsDetailed> GetDeviceWirelessZigbeeEnrollmentAsync(
		string serial,
		string enrollmentId, 
		CancellationToken cancellationToken = default);
}
