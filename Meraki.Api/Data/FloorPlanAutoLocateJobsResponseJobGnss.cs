namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Jobs Response Job Gnss
/// </summary>
[DataContract]
public class FloorPlansAutoLocateJobsResponseJobGnss
{
	/// <summary>
	/// GNSS status. Possible values: 'scheduled', 'in progress', 'error', 'finished', 'not applicable', 'canceled'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Progress information for the GNSS acquisition process
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "completed")]
	public FloorPlansAutoLocateJobsResponseJobCompleted Completed { get; set; } = new();
}
