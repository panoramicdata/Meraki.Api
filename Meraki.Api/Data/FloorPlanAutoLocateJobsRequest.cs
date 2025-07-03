namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Jobs Request
/// </summary>
[DataContract]
public class FloorPlansAutoLocateJobsRequest
{
	/// <summary>
	/// The list of auto locate jobs to be scheduled. Up to 100 jobs can be provided in a request.
	/// </summary>
	[DataMember(Name = "jobs")]
	public List<FloorPlansAutoLocateJobsRequestJob> Jobs { get; set; } = [];
}
