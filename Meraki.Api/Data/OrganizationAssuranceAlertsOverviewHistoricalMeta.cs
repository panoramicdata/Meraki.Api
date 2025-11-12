namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Overview Historical Meta
/// </summary>
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
