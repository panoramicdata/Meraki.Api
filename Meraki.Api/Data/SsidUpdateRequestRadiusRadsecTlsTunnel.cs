namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSsidRadiusRadsecTlsTunnel
/// </summary>
[DataContract]
public class SsidUpdateRequestRadiusRadsecTlsTunnel
{
	/// <summary>
	/// The interval (in seconds) to determines how long a TLS session can remain idle for a RADSec server before it is automatically terminated
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "timeout")]
	public int? Timeout { get; set; }
}
