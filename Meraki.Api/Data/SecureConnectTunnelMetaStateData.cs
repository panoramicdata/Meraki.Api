namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelClientMetaStateData
/// </summary>
[DataContract]
public class SecureConnectTunnelMetaStateData
{
	/// <summary>
	/// The number of processed input bytes (tunnel ingress).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "bytesIn")]
	public string BytesIn { get; set; } = string.Empty;

	/// <summary>
	/// The number of processed output bytes (tunnel egress).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "bytesOut")]
	public string BytesOut { get; set; } = string.Empty;

	/// <summary>
	/// The idle time (seconds since last inbound packet).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "idleTimeIn")]
	public string IdleTimeIn { get; set; } = string.Empty;

	/// <summary>
	/// The idle time (seconds since last outbound packet).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "idleTimeOut")]
	public string IdleTimeOut { get; set; } = string.Empty;

	/// <summary>
	/// The time when packet and byte counters were initialized to 0.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "initialized")]
	public string Initialized { get; set; } = string.Empty;

	/// <summary>
	/// The number of processed input packets (tunnel ingress).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "packetsIn")]
	public string PacketsIn { get; set; } = string.Empty;

	/// <summary>
	/// The number of processed output packets (tunnel egress).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "packetsOut")]
	public string PacketsOut { get; set; } = string.Empty;
}
