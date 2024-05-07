namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Result Speeds
/// </summary>
[DataContract]

public class LiveToolsThroughputTestResultSpeeds
{
	/// <summary>
	/// Shows the download speed from shard in (Mbps)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downstream")]
	public double Downstream { get; set; }

}
