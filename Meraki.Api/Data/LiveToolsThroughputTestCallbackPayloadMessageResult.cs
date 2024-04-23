namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload Message Result
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class LiveToolsThroughputTestCallbackPayloadMessageResult
{
	/// <summary>
	///  Shows the speeds in (KB/s)
	/// </summary>
	[DataMember(Name = "speeds")]
	public LiveToolsThroughputTestCallbackPayloadMessageResultSpeeds? Speeds { get; set; }
}
