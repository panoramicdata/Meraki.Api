namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Create Response
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCreateResponse
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
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your throughput test request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsThroughputTestCreateResponseCallback Callback { get; set; } = new();

	/// <summary>
	/// The parameters of the throughput test request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public LiveToolsThroughputTestCreateResponseRequest Request { get; set; } = new();

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "result")]
	public LiveToolsThroughputTestCreateResponseResult Result { get; set; } = new();
}
