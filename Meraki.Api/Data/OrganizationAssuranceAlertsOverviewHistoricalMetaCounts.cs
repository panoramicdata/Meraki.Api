namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Overview Historical Meta Counts
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertsOverviewHistoricalMetaCounts
{
	/// <summary>
	/// Total Alerts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public int Items { get; set; }
}
