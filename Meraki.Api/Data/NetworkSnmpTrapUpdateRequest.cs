namespace Meraki.Api.Data;

/// <summary>
/// Network SNMP Trap Update Request
/// </summary>
[DataContract]
public class NetworkSnmpTrapUpdateRequest
{
	/// <summary>
	/// SNMP trap protocol version
	/// </summary>
	[DataMember(Name = "mode")]
	public NetworkSnmpTrapMode Mode { get; set; }

	/// <summary>
	/// Stores the port and address
	/// </summary>
	[DataMember(Name = "receiver")]
	public NetworkSnmpTrapReceiver? Receiver { get; set; }

	/// <summary>
	/// V2 Mode
	/// </summary>
	[DataMember(Name = "v2")]
	public NetworkSnmpTrapV2? V2 { get; set; }

	/// <summary>
	/// V3 Mode
	/// </summary>
	[DataMember(Name = "v3")]
	public NetworkSnmpTrapV3Request? V3 { get; set; }
}
