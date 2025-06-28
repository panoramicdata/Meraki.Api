namespace Meraki.Api.Data;

/// <summary>
/// Network client counts
/// </summary>
[DataContract]
public class NetworkStatusSummaryClientsCounts
{
	/// <summary>
	/// Total count of clients in network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}