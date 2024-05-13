namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverviewByTypeMeta
{
	/// <summary>
	/// Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationAssuranceAlertsOverviewByTypeMetaCounts Counts { get; set; } = new();
}
