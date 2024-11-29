namespace Meraki.Api.Data;

/// <summary>
/// FloorPlanBatchDevicesUpdateRequestAssignmentFloorPlan
/// </summary>
[DataContract]
public class FloorPlanBatchDevicesUpdateRequestAssignmentFloorPlan
{
	/// <summary>
	/// The ID of the floor plan to assign the device to, or null to unassign the device from its floor plan
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

}
