namespace Meraki.Api.Data;

/// <summary>
/// Results of the trace route
/// </summary>
[DataContract]
public class DeviceLiveToolsTraceRouteGetResponseResult
{
	/// <summary>
	/// Probe Count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Hop number in the trace route result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hop")]
	public int Hop { get; set; }

	/// <summary>
	/// IP address of the hop if known
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// Average round trip time in seconds
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rttAvg")]
	public int RttAvg { get; set; }
}