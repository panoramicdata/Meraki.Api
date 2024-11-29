namespace Meraki.Api.Data;

/// <summary>
/// Floor Plans Recalculate Auto Locate Job Device Auto Locate
/// </summary>
[DataContract]
public class FloorPlansRecalculateAutoLocateJobRequestDeviceAutoLocate
{
	/// <summary>
	/// Whether or not this device's location should be saved as a user-defined anchor
	/// </summary>
	[DataMember(Name = "isAnchor")]
	public bool IsAnchor { get; set; }

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
}
