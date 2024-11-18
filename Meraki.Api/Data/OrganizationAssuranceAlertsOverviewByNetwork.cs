namespace Meraki.Api.Data;

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
