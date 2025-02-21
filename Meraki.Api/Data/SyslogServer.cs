namespace Meraki.Api.Data;

/// <summary>
/// Syslog Server
/// </summary>
[DataContract]
[DebuggerDisplay("{Host}:{Port}")]
public class SyslogServer
{
	/// <summary>
	/// The IP address of the syslog server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "host")]
	public string Host { get; set; } = string.Empty;

	/// <summary>
	/// The port of the syslog server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "port")]
	public int Port { get; set; }

	/// <summary>
	/// transportProtocol - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "transportProtocol")]
	public string? TransportProtocol { get; set; }

	/// <summary>
	/// Encryption settings for the syslog server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "encryption")]
	public SyslogServerEncryption? Encryption { get; set; }

	/// <summary>
	/// A list of roles for the syslog server. Options (case-insensitive): 'Wireless event log', 'Appliance event log', 'Switch event log', 'Air Marshal events', 'Flows', 'URLs', 'IDS alerts', 'Security events'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "roles")]
	public List<string> Roles { get; set; } = [];
}
