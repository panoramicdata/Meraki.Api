namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alert
/// </summary>
[DataContract]
public class OrganizationAssuranceAlert : IdentifiedItem
{
	/// <summary>
	/// Category type that the health alert belongs to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "categoryType")]
	public string CategoryType { get; set; } = string.Empty;

	/// <summary>
	/// Description containing additional details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Device Type that the alert occurred on
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceType")]
	public string DeviceType { get; set; } = string.Empty;

	/// <summary>
	/// Time when the alert was dismissed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dismissedAt")]
	public DateTime? DismissedAt { get; set; }

	/// <summary>
	/// Time when the alert was resolved
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "resolvedAt")]
	public DateTime? ResolvedAt { get; set; }

	/// <summary>
	/// Alert severity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "severity")]
	public string Severity { get; set; } = string.Empty;

	/// <summary>
	/// Time when the alert started
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startedAt")]
	public DateTime StartedAt { get; set; }

	/// <summary>
	/// Human Readable Title for Alert type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Alert Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Network details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationAssuranceAlertNetwork Network { get; set; } = new();

	/// <summary>
	/// Scope of the alert (which devices and networks are affected)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "scope")]
	public OrganizationAssuranceAlertScope Scope { get; set; } = new();
}
