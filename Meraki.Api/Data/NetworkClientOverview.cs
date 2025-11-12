namespace Meraki.Api.Data;

/// <summary>
/// Network Client Overview
/// </summary>
[DataContract]
public class NetworkClientOverview
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public NetworkClientOverviewCounts Counts { get; set; } = new();

	/// <summary>
	/// Usages
	/// </summary>
	[DataMember(Name = "usages")]
	public NetworkClientOverviewUsages Usages { get; set; } = new();
}
