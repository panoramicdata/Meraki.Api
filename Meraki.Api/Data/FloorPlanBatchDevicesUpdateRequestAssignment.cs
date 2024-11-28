namespace Meraki.Api.Data;

/// <summary>
/// FloorPlanBatchDevicesUpdateRequestAssignment
/// </summary>
[DataContract]
public class FloorPlanBatchDevicesUpdateRequestAssignment
{
	/// <summary>
	/// Serial of the device to change the floor plan assignment for
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Floorplan to be assigned or unassigned
	/// </summary>
	[DataMember(Name = "floorPlan")]
	public FloorPlanBatchDevicesUpdateRequestAssignment FloorPlan { get; set; } = new();

}
