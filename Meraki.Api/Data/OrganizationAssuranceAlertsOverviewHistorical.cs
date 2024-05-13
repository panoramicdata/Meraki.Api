namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverviewHistorical
{
	/// <summary>
	/// Metadata about the response
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationAssuranceAlertsOverviewHistoricalMeta Meta { get; set; } = new();

	/// <summary>
	///Historical Severity Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationAssuranceAlertsOverviewHistoricalItem> Items { get; set; } = new();
}
