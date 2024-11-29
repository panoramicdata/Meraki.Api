namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Jobs Response Job Ranging
/// </summary>
[DataContract]
public class FloorPlansAutoLocateJobsResponseJobRanging
{
	/// <summary>
	/// Ranging status. Possible values: 'scheduled', 'in progress', 'error', 'finished', 'no neighbors'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Progress information for the ranging process
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "completed")]
	public FloorPlansAutoLocateJobsResponseJobCompleted Completed { get; set; } = new();
}
