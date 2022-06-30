namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAdaptivePolicyOverview
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public OrganizationAdaptivePolicyOverviewCounts Counts { get; set; } = new();
}
