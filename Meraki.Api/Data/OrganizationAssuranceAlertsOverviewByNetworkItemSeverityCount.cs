namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverviewByNetworkItemSeverityCount
{
	/// <summary>
	/// Count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

}
