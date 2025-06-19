namespace Meraki.Api.Data;

/// <summary>
/// Network clients data
/// </summary>
[DataContract]
public class NetworkStatusSummaryClients
{
	/// <summary>
	/// Network client counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public NetworkStatusSummaryClientsCounts Counts { get; set; } = new();

	/// <summary>
	/// Network client usage data
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usage")]
	public NetworkStatusSummaryClientsUsage Usage { get; set; } = new();
}
