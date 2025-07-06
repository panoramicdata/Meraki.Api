namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Trace Route Create Request
/// </summary>
[DataContract]
public class DeviceLiveToolsTraceRouteCreateRequest
{
	/// <summary>
	/// Source Interface IP address
	/// </summary>
	[DataMember(Name = "sourceInterface ")]
	public string SourceInterface { get; set; } = string.Empty;

	/// <summary>
	/// Destination Host name or address
	/// </summary>
	[DataMember(Name = "target")]
	public string Target { get; set; } = string.Empty;

	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public DeviceLiveToolsTraceRouteCreateRequestCallback? Callback { get; set; }
}
