namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Routing Table Get Response.
/// </summary>
[DataContract]
public class DeviceLiveToolsRoutingTableGetResponse
{
	/// <summary>
	/// An error message for a failed execution
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

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
	/// Routing table request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsRoutingTableGetResponseRequest Request { get; set; } = new();

	/// <summary>
	/// Routing table entries
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "entries")]
	public List<DeviceLiveToolsRoutingTableGetResponseEntry> Entries { get; set; } = [];
}
