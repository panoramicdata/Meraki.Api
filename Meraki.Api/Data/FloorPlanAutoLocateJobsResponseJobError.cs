namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Jobs Response Job Error
/// </summary>
[DataContract]
public class FloorPlansAutoLocateJobsResponseJobError
{
	/// <summary>
	/// The step of the auto locate process when the error occurred. Possible values: 'gnss', 'ranging', 'positioning'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public string Source { get; set; } = string.Empty;

	/// <summary>
	/// The type of error that occurred. Possible values: 'failure', 'no neighbors', 'missing anchors', 'wrong anchors', 'calculation failure', 'scheduling failure'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}
