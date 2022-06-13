namespace Meraki.Api.Data;

/// <summary>
/// Camera Custom Analytics Artifact Creation Response
/// </summary>
[DataContract]
public class CameraCustomAnalyticsArtifactCreateResponse : CameraCustomAnalyticsArtifact
{
	/// <summary>
	/// UploadId
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uploadId")]
	public string UploadId { get; set; } = string.Empty;

	/// <summary>
	/// uploadUrl
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uploadUrl")]
	public string UploadUrl { get; set; } = string.Empty;

	/// <summary>
	/// Parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uploadUrlExpiry")]
	public DateTime UploadUrlExpiry { get; set; }
}
