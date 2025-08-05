namespace Meraki.Api.Data;

/// <summary>
/// Traffic Filter
/// </summary>
[DataContract]
public class OrganizationApplianceSdwanInternetPoliciesPreferenceTrafficFilter
{
	/// <summary>
	/// Traffic filter type. Must be 'custom', 'major_application', 'application (NBAR)', if type is 'application', you can pass either an NBAR App Category or Application. enum = ["application", "custom", "majorApplication"]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Value of traffic filter
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "value")]
	public OrganizationApplianceSdwanInternetPoliciesPreferenceTrafficFilterValue Value { get; set; } = new();
}
