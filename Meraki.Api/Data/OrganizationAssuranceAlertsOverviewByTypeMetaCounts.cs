namespace Meraki.Api.Data;

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
