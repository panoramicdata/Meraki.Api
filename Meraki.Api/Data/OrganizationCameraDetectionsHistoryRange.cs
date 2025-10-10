namespace Meraki.Api.Data;

/// <summary>
/// Organization Camera Detections History Range
/// </summary>
[DataContract]
public class OrganizationCameraDetectionsHistoryRange
{
	/// <summary>
	/// The range interval in seconds
	/// </summary>
	[DataMember(Name = "interval")]
	public int Interval { get; set; }

	/// <summary>
	/// The range end time
	/// </summary>
	[DataMember(Name = "endTime")]
	public DateTime EndTime { get; set; }

	/// <summary>
	/// The range start time
	/// </summary>
	[DataMember(Name = "startTime")]
	public DateTime StartTime { get; set; }
}
