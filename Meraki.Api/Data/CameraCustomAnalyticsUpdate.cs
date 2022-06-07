namespace Meraki.Api.Data;

/// <summary>
/// Camera Custom Analytics Update
/// </summary>
[DataContract]
public class CameraCustomAnalyticsUpdate
{
	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// ArtifactId
	/// </summary>
	[DataMember(Name = "artifactId")]
	public string? ArtifactId { get; set; } = string.Empty;

	/// <summary>
	/// Parameters
	/// </summary>
	[DataMember(Name = "parameters")]
	public List<CameraCustomAnalyticsParameters>? Parameters { get; set; } = new();
}
