namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverviewByNetworkMetaCounts
{
	/// <summary>
	/// Total Alerts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public int Items { get; set; }
}
