namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Overview By Type Meta Counts
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertsOverviewByTypeMetaCounts
{
	/// <summary>
	/// Total Alerts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public int Items { get; set; }
}
