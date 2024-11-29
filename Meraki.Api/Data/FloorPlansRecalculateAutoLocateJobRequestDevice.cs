namespace Meraki.Api.Data;

/// <summary>
/// Floor Plans Recalculate Auto Locate Job Device
/// </summary>
[DataContract]
public class FloorPlansRecalculateAutoLocateJobRequestDevice
{
	/// <summary>
	/// Serial for device to publish position for
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// The auto locate position for this device
	/// </summary>
	[DataMember(Name = "autoLocate")]
	public FloorPlansRecalculateAutoLocateJobRequestDeviceAutoLocate? AutoLocate { get; set; }
}
