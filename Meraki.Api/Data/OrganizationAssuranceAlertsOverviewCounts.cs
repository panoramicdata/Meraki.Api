namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverviewCounts
{
	/// <summary>
	/// Total number of alerts on the organization
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Counts of alerts on organization by severity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "bySeverity")]
	public List<OrganizationAssuranceAlertsOverviewCountsBySeverity> BySeverity { get; set; } = [];
}
