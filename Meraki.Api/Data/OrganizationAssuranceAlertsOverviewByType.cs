namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Overview By Type
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertsOverviewByType
{
	/// <summary>
	/// Metadata about the response
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationAssuranceAlertsOverviewByTypeMeta Meta { get; set; } = new();

	/// <summary>
	/// Alert Counts by Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationAssuranceAlertsOverviewByTypeItem> Items { get; set; } = [];
}
