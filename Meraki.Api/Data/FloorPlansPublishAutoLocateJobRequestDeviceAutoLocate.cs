namespace Meraki.Api.Data;

/// <summary>
/// Floor Plans Auto Locate Job Device Auto Locate
/// </summary>
[DataContract]
public class FloorPlansPublishAutoLocateJobRequestDeviceAutoLocate
{
	/// <summary>
	/// Whether or not this device's location should be saved as a user-defined anchor
	/// </summary>
	[DataMember(Name = "isAnchor")]
	public bool IsAnchor { get; set; }
}
