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
	[DataMember(Name = "requestIp")]
	public string RequestIp { get; set; } = string.Empty;

	/// <summary>
	/// Heartbeat interval
	/// </summary>
	[DataMember(Name = "heartbeatInterval")]
	public int HeartbeatInterval { get; set; }

	/// <summary>
	/// Idle timeout
	/// </summary>
	[DataMember(Name = "idleTimeout")]
	public int IdleTimeout { get; set; }
}