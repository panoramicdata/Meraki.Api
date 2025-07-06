namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Multicast Routing Create Response
/// </summary>
[DataContract]
public class DeviceLiveToolsMulticastRoutingCreateResponse
{
	/// <summary>
	/// ID of the Multicast routing request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "multicastRoutingId")]
	public string MutlicastRoutingId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the Multicast routing request. enum = ["complete", "failed", "new", "ready", "running", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this URL to check the status of your Multicast routing request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public DeviceLiveToolsMulticastRoutingCreateResponseCallback Callback { get; set; } = new();

	/// <summary>
	/// Multicast routing request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsMulticastRoutingCreateResponseRequest Request { get; set; } = new();
}
