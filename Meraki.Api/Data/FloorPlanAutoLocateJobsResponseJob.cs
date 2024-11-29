namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Jobs Response Job
/// </summary>
[DataContract]
public class FloorPlansAutoLocateJobsResponseJob
{
	/// <summary>
	/// The ID of the floor plan to run auto locate for
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "floorPlanId")]
	public string FloorPlanId { get; set; } = string.Empty;

	/// <summary>
	/// Auto locate job ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Scheduled start time for auto locate job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "scheduledAt")]
	public DateTime ScheduledAt { get; set; }

	/// <summary>
	/// Auto locate job status. Possible values: 'scheduled', 'in progress', 'canceling', 'error', 'finished', 'published', 'canceled'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Auto locate job progress information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "completed")]
	public FloorPlansAutoLocateJobsResponseJobCompleted Completed { get; set; } = new();

	/// <summary>
	/// GNSS (e.g. GPS) status and progress information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "gnss")]
	public FloorPlansAutoLocateJobsResponseJobGnss Gnss { get; set; } = new();

	/// <summary>
	/// Ranging status and progress information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ranging")]
	public FloorPlansAutoLocateJobsResponseJobRanging Ranging { get; set; } = new();

	/// <summary>
	/// List of errors that occurred during a failed run of auto locate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "errors")]
	public List<FloorPlansAutoLocateJobsResponseJobError> Errors { get; set; } = [];
}
