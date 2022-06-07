namespace Meraki.Api.Data;

/// <summary>
/// Camera Custom Analytics Artifact Creation Return
/// </summary>
[DataContract]
public class CameraCustomAnalyticsArtifactCreate : CameraCustomAnalyticsArtifact
{
	/// <summary>
	/// UploadId
	/// </summary>
	[DataMember(Name = "uploadId")]
	public string UploadId { get; set; } = string.Empty;

	/// <summary>
	/// uploadUrl
	/// </summary>
	[DataMember(Name = "uploadUrl")]
	public string UploadUrl { get; set; } = string.Empty;

	/// <summary>
	/// Parameters
	/// </summary>
	[DataMember(Name = "uploadUrlExpiry")]
	public DateTime UploadUrlExpiry { get; set; }
}
