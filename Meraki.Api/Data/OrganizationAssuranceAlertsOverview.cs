namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverview
{
	/// <summary>
	/// Counts of alerts on the organization
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationAssuranceAlertsOverviewCounts Counts { get; set; } = new();

}
