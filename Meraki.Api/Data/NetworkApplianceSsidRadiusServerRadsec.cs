namespace Meraki.Api.Data;

/// <summary>
/// RADSEC settings for an appliance SSID RADIUS server - Undocumented, observed in responses only
/// </summary>
[DataContract]
public class NetworkApplianceSsidRadiusServerRadsec
{
	/// <summary>
	/// Whether RADSEC is enabled for the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// The interval (in seconds) that determines how long a TLS session can remain idle for a RADSec server before it is automatically terminated
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tlsIdleTimeout")]
	public int? TlsIdleTimeout { get; set; }
}
