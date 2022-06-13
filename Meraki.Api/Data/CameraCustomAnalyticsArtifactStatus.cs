namespace Meraki.Api.Data;

/// <summary>
/// Camera Custom Analytics Artifact Status
/// </summary>
[DataContract]
public class CameraCustomAnalyticsArtifactStatus
{
	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Message
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "message")]
	public string? Message { get; set; }
}
