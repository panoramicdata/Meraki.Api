namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Overview By Type Item Severity Count
/// </summary>
[Obsolete("The Dashboard API never returned severity counts on the by-type overview; OrganizationAssuranceAlertsOverviewByTypeItem now follows the documented shape. This type will be removed in a later release.")]
[DataContract]
public class OrganizationAssuranceAlertsOverviewByTypeItemSeverityCount
{
	/// <summary>
	/// Count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}
