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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "artifactId")]
	public string ArtifactId { get; set; } = string.Empty;

	/// <summary>
	/// OrganizationId
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// Parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public CameraCustomAnalyticsArtifactStatus Status { get; set; } = new();
}
