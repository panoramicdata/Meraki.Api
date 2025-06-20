namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Jobs Response
/// </summary>
[DataContract]
public class FloorPlansAutoLocateJobsResponse
{
	/// <summary>
	/// The newly created jobs
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "jobs")]
	public List<FloorPlansAutoLocateJobsResponseJob> Jobs { get; set; } = [];
}
