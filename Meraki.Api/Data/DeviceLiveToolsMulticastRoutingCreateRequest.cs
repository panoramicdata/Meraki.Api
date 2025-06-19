namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Multicast Routing Create Request
/// </summary>
[DataContract]
public class DeviceLiveToolsMulticastRoutingCreateRequest
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public DeviceLiveToolsMulticastRoutingCreateRequestCallback? Callback { get; set; }
}
