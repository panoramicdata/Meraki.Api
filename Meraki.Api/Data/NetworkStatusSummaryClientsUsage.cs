namespace Meraki.Api.Data;

/// <summary>
/// Network client usage data
/// </summary>
[DataContract]
public class NetworkStatusSummaryClientsUsage
{
	/// <summary>
	/// Total downstream usage in network, in KB
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downstream")]
	public int Downstream { get; set; }

	/// <summary>
	/// Total upstream usage in network, in KB
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upstream")]
	public int Upstream { get; set; }
}