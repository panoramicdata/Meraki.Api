namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Multicast Routing Get Response
/// </summary>
[DataContract]
public class DeviceLiveToolsMulticastRoutingGetResponse
{
	/// <summary>
	/// Description of the error.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// ID of the Multicast routing request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "multicastRoutingId")]
	public string MulticastRoutingId { get; set; } = string.Empty;

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
	/// Multicast routing request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsMulticastRoutingGetResponseRequest Request { get; set; } = new();

	/// <summary>
	/// The interfaces that have PIM enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interfaces")]
	public List<DeviceLiveToolsMulticastRoutingGetResponseInterface> Interfaces { get; set; } = [];

	/// <summary>
	/// The multicast routes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "routes")]
	public List<DeviceLiveToolsMulticastRoutingGetResponseRoute> Routes { get; set; } = [];
}
