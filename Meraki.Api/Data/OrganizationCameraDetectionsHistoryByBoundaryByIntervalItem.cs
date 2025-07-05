namespace Meraki.Api.Data;

/// <summary>
/// Organization Camera Detections History By Boundary By Interval Item
/// </summary>
[DataContract]
public class OrganizationCameraDetectionsHistoryByBoundaryByIntervalItem
{
	/// <summary>
	/// The boundary id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "boundaryId")]
	public string BoundaryId { get; set; } = string.Empty;

	/// <summary>
	/// The boundary type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// The analytics data
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "results")]
	public OrganizationCameraDetectionsHistoryByBoundaryByIntervalItemResults Results { get; set; } = new();
}
