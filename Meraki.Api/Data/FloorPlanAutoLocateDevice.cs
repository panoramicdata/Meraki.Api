namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Device
/// </summary>
[DataContract]
public class FloorPlansAutoLocateDevice
{
	/// <summary>
	/// MAC Address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// Model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Device Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Device Serial Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Device Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The type of auto locate position. Possible values: 'user', 'gnss', and 'calculated'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not this auto locate position is an anchor
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isAnchor")]
	public bool InAnchor { get; set; }

	/// <summary>
	/// Latitude
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lat")]
	public string Lat { get; set; } = string.Empty;

	/// <summary>
	/// Longitude
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lng")]
	public string Lng { get; set; } = string.Empty;

	/// <summary>
	/// Tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// The auto locate position for this device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "autoLocate")]
	public GeoLocation AutoLocate { get; set; } = new();

	/// <summary>
	/// The assigned floor plan for this device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "floorPlan")]
	public FloorPlansAutoLocateDeviceFloorPlan FloorPlan { get; set; } = new();

	/// <summary>
	/// Network info
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public FloorPlansAutoLocateDeviceNetwork Network { get; set; } = new();
}
