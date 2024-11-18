namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverviewCountsBySeverity
{
	/// <summary>
	/// Total count of the given severity type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Severity Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}
