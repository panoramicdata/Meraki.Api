namespace Meraki.Api.Data;

/// <summary>
/// Health alert
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class HealthAlert
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Category
	/// </summary>
	[DataMember(Name = "category")]
	public string Category { get; set; } = string.Empty;

	/// <summary>
	/// Type
	/// </summary>	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Severity
	/// </summary>
	[DataMember(Name = "severity")]
	public string Severity { get; set; } = string.Empty;

	/// <summary>
	/// Scope
	/// </summary>
	[DataMember(Name = "scope")]
	public HealthAlertScope Scope { get; set; } = new();
}
