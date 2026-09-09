namespace Meraki.Api.Data;

/// <summary>
/// Organization Adaptive Policy Overview
/// </summary>
[DataContract]
public class OrganizationAdaptivePolicyOverview
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public OrganizationAdaptivePolicyOverviewCounts Counts { get; set; } = new();

	/// <summary>
	/// The current limits of various adaptive policy objects
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "limits")]
	public OrganizationAdaptivePolicyOverviewLimits? Limits { get; set; }
}
