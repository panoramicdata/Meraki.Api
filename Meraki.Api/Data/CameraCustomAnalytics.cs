namespace Meraki.Api.Data;

/// <summary>
/// Camera Custom Analytics
/// </summary>
[DataContract]
public class CameraCustomAnalytics
{
	/// <summary>
	/// Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// ArtifactId
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "artifactId")]
	public string ArtifactId { get; set; } = string.Empty;

	/// <summary>
	/// Parameters
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "parameters")]
	public List<CameraCustomAnalyticsParameters> Parameters { get; set; } = new();
}
