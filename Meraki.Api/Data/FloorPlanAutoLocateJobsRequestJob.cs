namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Jobs Request Job
/// </summary>
[DataContract]
public class FloorPlansAutoLocateJobsRequestJob
{
	/// <summary>
	/// The ID of the floor plan to run auto locate for
	/// </summary>
	[DataMember(Name = "floorPlanId")]
	public string FloorPlanId { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp in ISO8601 format which indicates when the auto locate job should be run. If omitted, the auto locate job will start immediately.
	/// </summary>
	[DataMember(Name = "scheduledAt")]
	public DateTime ScheduledAt { get; set; }

	/// <summary>
	/// The types of location data that should be refreshed for this job. 
	/// The list must either contain both 'gnss' and 'ranging' or be empty, 
	/// as we currently only support refreshing both 'gnss' and 'ranging', or neither.
	/// </summary>
	[DataMember(Name = "refresh")]
	public List<string> Refresh { get; set; } = [];
}
