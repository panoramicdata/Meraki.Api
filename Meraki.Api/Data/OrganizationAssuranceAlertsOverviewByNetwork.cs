namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Overview By Network
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertsOverviewByNetwork
{
	/// <summary>
	/// Metadata about the response
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationAssuranceAlertsOverviewByNetworkMeta Meta { get; set; } = new();

	/// <summary>
	/// Alert Counts by Network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationAssuranceAlertsOverviewByNetworkItem> Items { get; set; } = [];
}
