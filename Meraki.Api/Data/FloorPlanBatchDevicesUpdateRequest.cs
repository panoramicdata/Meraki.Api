namespace Meraki.Api.Data;

/// <summary>
/// FloorPlanBatchDevicesUpdateRequest
/// </summary>
[DataContract]
public class FloorPlanBatchDevicesUpdateRequest
{
	/// <summary>
	/// List of floorplan assignments to update. Up to 100 floor plan assignments can be provided in a request.
	/// </summary>
	[DataMember(Name = "assignments")]
	public List<FloorPlanBatchDevicesUpdateRequestAssignment> Assignments { get; set; } = new();

}
