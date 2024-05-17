namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverviewHistoricalItem
{
	/// <summary>
	/// Starting datetime of the segment in iso8601 format
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "segmentStart")]
	public string SegmentStart { get; set; } = string.Empty;

	/// <summary>
	/// Totals by Severity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "totals")]
	public OrganizationAssuranceAlertsOverviewHistoricalItemTotals Totals { get; set; } = new();

	/// <summary>
	/// Totals by Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byAlertType")]
	public List<OrganizationAssuranceAlertsOverviewHistoricalItemByAlertType> byAlertType { get; set; } = [];
}
