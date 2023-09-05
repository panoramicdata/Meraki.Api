namespace Meraki.Api.Data;

/// <summary>
/// Beacon ID Params on a floorplan device - Undocumented
/// </summary>
[DataContract]
[ApiAccessReadOnlyClass]
public class FloorplanDeviceBeaconIdParams
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[DataMember(Name = "uuid")]
	public string? Uuid { get; set; }

	/// <summary>
	/// Undocumented
	/// </summary>
	[DataMember(Name = "major")]
	public int? Major { get; set; }

	/// <summary>
	/// Undocumented
	/// </summary>
	[DataMember(Name = "minor")]
	public int? Minor { get; set; }

}
