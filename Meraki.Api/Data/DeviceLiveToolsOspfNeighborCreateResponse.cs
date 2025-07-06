namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools OSPF Neighbor Create Response
/// </summary>
[DataContract]
public class DeviceLiveToolsOspfNeighborCreateResponse
{
	/// <summary>
	/// ID of the OSPF neighbors request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ospfNeighborsId")]
	public string OspfNeighborId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the OSPF neighbors request. enum = ["complete", "failed", "new", "ready", "running", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this URL to check the status of your OSPF neighbors request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public DeviceLiveToolsOspfNeighborCreateResponseCallback Callback { get; set; } = new();

	/// <summary>
	/// OSPF neighbors request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsOspfNeighborCreateResponseRequest Request { get; set; } = new();
}
