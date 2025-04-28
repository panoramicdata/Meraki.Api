namespace Meraki.Api.Interfaces.General.Devices;
public interface IDevicesWirelessZigbeeEnrollments
{
	/// <summary>
	/// Enqueue a job to start enrolling doorlocks on zigbee configured MRs
	/// </summary>
	/// <param name="serial"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("devices/{serial}/wireless/zigbee/enrollments")]
	Task<DevicesWirelessZigbeeEnrollmentsCreateResponse> CreateDeviceWirelessZigbeeEnrollmentAsync(string serial,
		CancellationToken cancellationToken = default);
}
