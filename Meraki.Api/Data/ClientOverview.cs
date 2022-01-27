namespace Meraki.Api.Data;
[DataContract]
public class ClientOverview
{
	/// <summary>
	/// Usage
	/// </summary>
	[DataMember(Name = "usage")]
	public ClientOverviewUsage usage { get; set; } = new();

	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public ClientOverviewCounts Counts { get; set; } = new();
}
