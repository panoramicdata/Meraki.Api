namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload Message
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class LiveToolsThroughputTestCallbackPayloadMessage
{
	/// <summary>
	///  Description of the error.
	/// </summary>
	[DataMember(Name = "error")]
	public string? Error { get; set; }

	/// <summary>
	/// Status of the throughput test request
	/// </summary>
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// ID of throughput test job
	/// </summary>
	[DataMember(Name = "throughputTestId")]
	public string? ThroughputId { get; set; }

	/// <summary>
	/// GET this url to check the status of your throughput test request
	/// </summary>
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// The parameters of the throughput test request
	/// </summary>
	[DataMember(Name = "request")]
	public LiveToolsThroughputTestCallbackPayloadMessageRequest? Request { get; set; }

	/// <summary>
	/// Result of the throughput test request
	/// </summary>
	[DataMember(Name = "result")]
	public LiveToolsThroughputTestCallbackPayloadMessageResult? Result { get; set; }
}
