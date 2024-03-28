namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload Message ResultSpeeds
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCallbackMessageResultSpeeds
{
	/// <summary>
	///  Shows the download speed from shard in (Mbps)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "downstream")]
	public int? Downstream { get; set; }
}
