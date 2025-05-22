namespace Meraki.Api.Data;

/// <summary>
/// V2 Mode
/// </summary>
[DataContract]
public class NetworkSnmpTrapV2
{
	/// <summary>
	/// The community string used for SNMP V1/V2 access
	/// </summary>
	[DataMember(Name = "community")]
	public string? Community { get; set; }
}
