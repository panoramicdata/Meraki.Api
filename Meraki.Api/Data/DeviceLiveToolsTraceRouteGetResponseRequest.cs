namespace Meraki.Api.Data;

/// <summary>
/// Traceroute request parameters
/// </summary>
[DataContract]
public class DeviceLiveToolsTraceRouteGetResponseRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Source Interface IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sourceInterface")]
	public string SourceInterface { get; set; } = string.Empty;

	/// <summary>
	/// Destination Host name or address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "target")]
	public string Target { get; set; } = string.Empty;
}