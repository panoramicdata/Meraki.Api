namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Trace Route Get Response
/// </summary>
[DataContract]
public class DeviceLiveToolsTraceRouteGetResponse
{
	/// <summary>
	/// An error message for a failed execution
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// Status of the trace route request. enum = ["complete", "failed", "new", "ready", "running", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Id of the trace route request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "traceRouteId")]
	public string TraceRouteId { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your trace route request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Traceroute request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsTraceRouteGetResponseRequest Request { get; set; } = new();

	/// <summary>
	/// Results of the trace route
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "results")]
	public List<DeviceLiveToolsTraceRouteGetResponseResult> Results { get; set; } = [];
}
