namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload Message ResultSpeeds
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class LiveToolsThroughputTestCallbackMessageResultSpeeds
{
	/// <summary>
	///  Shows the download speed from shard in (Mbps)
	/// </summary>
	[DataMember(Name = "downstream")]
	public int? Downstream { get; set; }
}
