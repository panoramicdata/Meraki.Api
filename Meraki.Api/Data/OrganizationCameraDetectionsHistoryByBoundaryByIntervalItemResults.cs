namespace Meraki.Api.Data;

/// <summary>
/// The analytics data
/// </summary>
[DataContract]
public class OrganizationCameraDetectionsHistoryByBoundaryByIntervalItemResults
{
	/// <summary>
	/// The number of detections entered
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "in")]
	public int In { get; set; }

	/// <summary>
	/// The number of detections exited
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "out")]
	public int Out { get; set; }

	/// <summary>
	/// The period end time
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTime")]
	public string EndTime { get; set; } = string.Empty;

	/// <summary>
	/// The detection type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "objectType")]
	public string ObjectType { get; set; } = string.Empty;

	/// <summary>
	/// The period start time
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTime")]
	public string StartTime { get; set; } = string.Empty;
}