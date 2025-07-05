namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Routing Table Create Response.
/// </summary>
[DataContract]
public class DeviceLiveToolsRoutingTableCreateResponse
{
	/// <summary>
	/// Id of the routing table request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "routingTableId")]
	public string RoutingTableId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the routing table request. enum = ["complete", "failed", "new", "ready", "running", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your routing table request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public DeviceLiveToolsRoutingTableCreateResponseCallback Callback { get; set; } = new();

	/// <summary>
	/// Routing table request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsRoutingTableCreateResponseRequest Request { get; set; } = new();
}
