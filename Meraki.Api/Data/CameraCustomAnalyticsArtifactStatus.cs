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
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Message
	/// </summary>
	[DataMember(Name = "message")]
	public string? Message { get; set; }
}
