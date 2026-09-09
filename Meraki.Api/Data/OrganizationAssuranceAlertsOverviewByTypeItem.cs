namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Overview By Type Item
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertsOverviewByTypeItem
{
	/// <summary>
	/// Alert type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Alert category
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "categoryType")]
	public string? CategoryType { get; set; }

	/// <summary>
	/// Alert severity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "severity")]
	public string? Severity { get; set; }

	/// <summary>
	/// Total count of the given alert type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "count")]
	public int? Count { get; set; }

	/// <summary>
	/// Number of affected networks for the alert type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkCount")]
	public int? NetworkCount { get; set; }

	/// <summary>
	/// Affected networks for alerts in the group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networks")]
	public List<OrganizationAssuranceAlertsOverviewByTypeItemNetwork> Networks { get; set; } = [];

	/// <summary>
	/// Affected device types for alerts in the group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceTypes")]
	public List<string> DeviceTypes { get; set; } = [];

	/// <summary>
	/// Unique device tags for alerts in the group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceTags")]
	public List<string> DeviceTags { get; set; } = [];

	/// <summary>
	/// Last time an alert of this type was triggered
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastAlertedAt")]
	public DateTime? LastAlertedAt { get; set; }

	/// <summary>
	/// Last time an alert of this type was resolved
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastResolvedAt")]
	public DateTime? LastResolvedAt { get; set; }
}
