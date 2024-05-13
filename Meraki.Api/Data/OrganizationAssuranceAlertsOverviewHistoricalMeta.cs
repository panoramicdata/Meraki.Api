namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverviewHistoricalMeta
{
	/// <summary>
	/// Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationAssuranceAlertsOverviewHistoricalMetaCounts Counts { get; set; } = new();
}
