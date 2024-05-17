namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverviewByNetworkMeta
{
	/// <summary>
	/// Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationAssuranceAlertsOverviewByNetworkMetaCounts Counts { get; set; } = new();
}
