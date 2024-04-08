namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload Message Result
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCallbackMessageResult
{
	/// <summary>
	///  Shows the speeds in (KB/s)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "speeds")]
	public LiveToolsThroughputTestCallbackMessageResultSpeeds? Speeds { get; set; }
}
