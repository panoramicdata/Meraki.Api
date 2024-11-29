namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Status
/// </summary>
[DataContract]
public class FloorPlansAutoLocateStatus
{
	/// <summary>
	/// Floor Plan ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "floorPlanId")]
	public string FloorPlanId { get; set; } = string.Empty;

	/// <summary>
	/// Device Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Counts for this floor plan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public FloorPlansAutoLocateStatusCounts Counts { get; set; } = new();

	/// <summary>
	/// Network info
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public FloorPlansAutoLocateStatusNetwork Network { get; set; } = new();

	/// <summary>
	/// The most recent job for this floor plan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "jobs")]
	public List<FloorPlansAutoLocateStatusJob> Jobs { get; set; } = [];
}
