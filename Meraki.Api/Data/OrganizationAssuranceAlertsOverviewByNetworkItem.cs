namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Overview By Network Item
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertsOverviewByNetworkItem
{
	/// <summary>
	/// Total Alerts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "alertCount")]
	public int AlertCount { get; set; }

	/// <summary>
	/// id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkName")]
	public string NetworkName { get; set; } = string.Empty;

	/// <summary>
	/// Alerts By Severity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "severityCounts")]
	public List<OrganizationAssuranceAlertsOverviewByNetworkItemSeverityCount> SeverityCounts { get; set; } = [];

	/// <summary>
	/// Last time an alert was seen for this network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastAlertedAt")]
	public DateTime? LastAlertedAt { get; set; }
}
