namespace Meraki.Api.Data;

/// <summary>
/// Floor Plans Auto Locate Job Device
/// </summary>
[DataContract]
public class FloorPlansPublishAutoLocateJobRequestDevice
{
	/// <summary>
	/// Serial for device to publish position for
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Latitude
	/// </summary>
	[DataMember(Name = "lat")]
	public double Lat { get; set; }

	/// <summary>
	/// Longitude
	/// </summary>
	[DataMember(Name = "lng")]
	public double Lng { get; set; }

	/// <summary>
	/// The auto locate position for this device
	/// </summary>
	[DataMember(Name = "autoLocate")]
	public FloorPlansPublishAutoLocateJobRequestDeviceAutoLocate? AutoLocate { get; set; }
}
