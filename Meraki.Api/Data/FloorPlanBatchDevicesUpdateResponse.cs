namespace Meraki.Api.Data;

/// <summary>
/// FloorPlanBatchDevicesUpdateResponse
/// </summary>
[DataContract]
public class FloorPlanBatchDevicesUpdateResponse
{
	/// <summary>
	/// Status of attempt to update device floorplan assignments
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "success")]
	public bool Success { get; set; }

}
