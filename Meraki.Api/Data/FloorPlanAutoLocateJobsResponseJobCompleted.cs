namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Jobs Response Job Completed
/// </summary>
[DataContract]
public class FloorPlansAutoLocateJobsResponseJobCompleted
{
	/// <summary>
	/// Approximate auto locate job completion percentage
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }

}
