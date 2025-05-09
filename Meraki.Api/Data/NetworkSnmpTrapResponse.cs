namespace Meraki.Api.Data;

/// <summary>
/// Network SNMP Trap Response
/// </summary>
[DataContract]
public class NetworkSnmpTrapResponse
{
	/// <summary>
	/// SNMP trap protocol version
	/// </summary>
	[DataMember(Name = "mode")]
	public NetworkSnmpTrapMode Mode { get; set; }

	/// <summary>
	/// Configuration details for the network
	/// </summary>
	[DataMember(Name = "network")]
	public NetworkSnmpTrapNetwork? Network { get; set; }

	/// <summary>
	/// SNMP trap receiver details
	/// </summary>
	[DataMember(Name = "receiver")]
	public NetworkSnmpTrapReceiver? Receiver { get; set; }

	/// <summary>
	/// Configuration details for SNMP v2
	/// </summary>
	[DataMember(Name = "v2")]
	public NetworkSnmpTrapV2? V2 { get; set; }

	/// <summary>
	/// Configuration details for SNMP v3
	/// </summary>
	[DataMember(Name = "v3")]
	public NetworkSnmpTrapV3Response? V3 { get; set; }
}