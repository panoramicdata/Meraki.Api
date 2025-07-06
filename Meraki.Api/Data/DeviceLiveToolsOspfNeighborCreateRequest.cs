namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools OSPF Neighbor Create Request
/// </summary>
[DataContract]
public class DeviceLiveToolsOspfNeighborCreateRequest
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public DeviceLiveToolsOspfNeighborCreateRequestCallback? Callback { get; set; }
}
