namespace Meraki.Api.Data;

/// <summary>
/// Organization SNMP Trap by Network
/// </summary>
[DataContract]
public class OrganizationSnmpTrapByNetwork
{
	/// <summary>
	/// SNMP trap protocol version (disabled, v1/v2c, v3)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string Mode { get; set; } = string.Empty;

	/// <summary>
	/// Configuration details for the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationSnmpTrapByNetworkNetwork Network { get; set; } = new();

	/// <summary>
	/// SNMP trap receiver details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "receiver")]
	public OrganizationSnmpTrapByNetworkReceiver Receiver { get; set; } = new();

	/// <summary>
	/// Configuration details for SNMP v2
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "v2")]
	public OrganizationSnmpTrapByNetworkV2 V2 { get; set; } = new();

	/// <summary>
	/// Configuration details for SNMP v3
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "v3")]
	public OrganizationSnmpTrapByNetworkV3 V3 { get; set; } = new();
}
