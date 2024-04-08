namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload Message
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCallbackMessage
{
	/// <summary>
	///  Description of the error.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "error")]
	public string? Error { get; set; }

	/// <summary>
	/// Status of the throughput test request
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// ID of throughput test job
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "throughputTestId")]
	public string? ThroughputId { get; set; }

	/// <summary>
	/// GET this url to check the status of your throughput test request
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// The parameters of the throughput test request
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "request")]
	public LiveToolsThroughputTestCallbackMessageRequest? Request { get; set; }

	/// <summary>
	/// Result of the throughput test request
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "result")]
	public LiveToolsThroughputTestCallbackMessageResult? Result { get; set; }
}
