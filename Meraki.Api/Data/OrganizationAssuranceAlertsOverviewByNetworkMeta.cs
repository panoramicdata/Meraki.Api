namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Overview By Network Meta
/// </summary>
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
