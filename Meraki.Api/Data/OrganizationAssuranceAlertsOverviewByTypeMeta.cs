namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Overview By Type Meta
/// </summary>
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
