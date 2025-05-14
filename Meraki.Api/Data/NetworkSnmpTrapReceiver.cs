namespace Meraki.Api.Data;

/// <summary>
/// Stores the port and address
/// </summary>
[DataContract]
public class NetworkSnmpTrapReceiver
{
	/// <summary>
	/// The IP address of the SNMP trap receiver
	/// </summary>
	[DataMember(Name = "address")]
	public string? Address { get; set; }

	/// <summary>
	/// The port number of the SNMP trap receiver
	/// </summary>
	[DataMember(Name = "port")]
	public string? Port { get; set; }
}