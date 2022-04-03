namespace Meraki.Api.Data;

/// <summary>
/// Failover
/// </summary>
[DataContract]
public class Failover
{
	/// <summary>
	/// Request IP
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "requestIp")]
	public string RequestIp { get; set; } = string.Empty;

	/// <summary>
	/// Heartbeat interval
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "heartbeatInterval")]
	public int HeartbeatInterval { get; set; }

	/// <summary>
	/// Idle timeout
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "idleTimeout")]
	public int IdleTimeout { get; set; }
}