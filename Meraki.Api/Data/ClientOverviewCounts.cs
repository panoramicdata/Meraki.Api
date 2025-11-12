namespace Meraki.Api.Data;

/// <summary>
/// Client Overview Counts
/// </summary>
[DataContract]
public class ClientOverviewCounts
{
	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
