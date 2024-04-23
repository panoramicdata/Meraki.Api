namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test
/// </summary>
[DataContract]

public class LiveToolsThroughputTest
{
	/// <summary>
	/// Description of the error.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// Status of the throughput test request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// ID of throughput test job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "throughputTestId")]
	public string ThroughputTestId { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your throughput test request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// The parameters of the throughput test request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public LiveToolsThroughputTestRequest Request { get; set; } = new();

	/// <summary>
	/// Result of the throughput test request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "result")]
	public LiveToolsThroughputTestResult Result { get; set; } = new();
}
