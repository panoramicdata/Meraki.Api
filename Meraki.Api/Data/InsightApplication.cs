namespace Meraki.Api.Data;

/// <summary>
/// Insight application
/// </summary>
[DataContract]
public class InsightApplication
{
	/// <summary>
	/// Application id
	/// </summary>
	[DataMember(Name = "applicationId")]
	public string ApplicationId { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Thresholds
	/// </summary>
	[DataMember(Name = "thresholds")]
	public Thresholds Thresholds { get; set; } = new();
}
