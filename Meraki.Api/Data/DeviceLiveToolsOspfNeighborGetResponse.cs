namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools OSPF Neighbor Get Response
/// </summary>
[DataContract]
public class DeviceLiveToolsOspfNeighborGetResponse
{
	/// <summary>
	/// Description of the error.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// ID of the OSPF neighbors request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ospfNeighborsId")]
	public string OspfNeighborsId { get; set; } = string.Empty;

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
	/// OSPF neighbors request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsOspfNeighborGetResponseRequest Request { get; set; } = new();

	/// <summary>
	/// The OSPF neighbors
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "routers")]
	public List<DeviceLiveToolsOspfNeighborGetResponseRouter> Routers { get; set; } = [];
}
