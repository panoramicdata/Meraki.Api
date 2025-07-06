namespace Meraki.Api.Data;

/// <summary>
/// Organization Insight Application
/// </summary>
[DataContract]
public class OrganizationInsightApplication
{
	/// <summary>
	/// Application identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "applicationId")]
	public string ApplicationId { get; set; } = string.Empty;

	/// <summary>
	/// Application name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Thresholds defined by a user or Meraki models for each application
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "thresholds")]
	public OrganizationInsightApplicationThresholds Thresholds { get; set; } = new();
}
