namespace Meraki.Api.Data;
/// <summary>
/// Client Overview
/// </summary>
[DataContract]
public class ClientOverview
{
	/// <summary>
	/// Usage
	/// </summary>
	[DataMember(Name = "usage")]
	public ClientOverviewUsage Usage { get; set; } = new();

	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public ClientOverviewCounts Counts { get; set; } = new();
}
