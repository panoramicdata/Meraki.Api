namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Trace Route Create Response
/// </summary>
[DataContract]
public class DeviceLiveToolsTraceRouteCreateResponse
{
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
	/// Information for callback used to send back results 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public DeviceLiveToolsTraceRouteCreateResponseCallback Callback { get; set; } = new();

	/// <summary>
	/// traceroute request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsTraceRouteCreateResponseRequest Request { get; set; } = new();
}
