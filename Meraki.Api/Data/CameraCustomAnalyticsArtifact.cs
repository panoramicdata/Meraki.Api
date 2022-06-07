namespace Meraki.Api.Data;

/// <summary>
/// Camera Custom Analytics Artifact
/// </summary>
[DataContract]
public class CameraCustomAnalyticsArtifact : NamedItem
{
	/// <summary>
	/// ArtifactId
	/// </summary>
	[DataMember(Name = "artifactId")]
	public string ArtifactId { get; set; } = string.Empty;

	/// <summary>
	/// OrganizationId
	/// </summary>
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// Parameters
	/// </summary>
	[DataMember(Name = "status")]
	public CameraCustomAnalyticsArtifactStatus Status { get; set; } = new();
}
