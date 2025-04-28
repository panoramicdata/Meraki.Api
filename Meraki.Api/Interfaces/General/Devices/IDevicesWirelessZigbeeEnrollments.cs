namespace Meraki.Api.Interfaces.General.Devices;
public interface IDevicesWirelessZigbeeEnrollments
{
	/// <summary>
	/// Enqueue a job to start enrolling doorlocks on zigbee configured MRs
	/// </summary>
	/// <param name="serial"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/devices/{serial}/wireless/zigbee/enrollments")]
	Task<DevicesWirelessZigbeeEnrollmentsCreateResponse> CreateDeviceWirelessZigbeeEnrollmentAsync(string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return an enrollment job
	/// </summary>
	/// <param name="serial"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/devices/{serial}/wireless/zigbee/enrollments/{id}")]
	Task<DevicesWirelessZigbeeEnrollmentsGetResponse> GetDeviceWirelessZigbeeEnrollmentAsync(string serial,
	string id, CancellationToken cancellationToken = default);
}
