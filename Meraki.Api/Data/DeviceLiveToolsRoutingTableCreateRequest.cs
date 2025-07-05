namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Routing Table Create Request.
/// </summary>
[DataContract]
public class DeviceLiveToolsRoutingTableCreateRequest
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public DeviceLiveToolsRoutingTableCreateRequestCallback? Callback { get; set; }
}
