namespace Meraki.Api.Sections.General.Devices;
/// <summary>
/// Provides access to devices wireless zigbee API endpoints
/// </summary>
public class DevicesWirelessZigbeeSection
{
	/// <summary>
	/// Enqueue a job to start enrolling doorlocks on zigbee configured MRs
	/// </summary>

	public IDevicesWirelessZigbeeEnrollments Enrollments { get; internal set; } = null!;
}
