namespace Meraki.Api.Data;

/// <summary>
/// Organization Extensions SD-WAN Manager Interconnect
/// </summary>
[DataContract]
public class OrganizationExtensionsSdwanManagerInterconnect
{
	/// <summary>
	/// BGP AS Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "asNum")]
	public int AsNum { get; set; }

	/// <summary>
	/// Number of tunnels formed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tunnelCount")]
	public int TunnelCount { get; set; }

	/// <summary>
	/// Number of VPNs participating in Interconnect
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vpnCount")]
	public int VpnCount { get; set; }

	/// <summary>
	/// Creation time of the Interconnect
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// ID of the interconnect
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the interconnect
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The network ID of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Locale Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkLocaleId")]
	public string NetworkLocaleId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the interconnect
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The type of interconnect
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Appliance ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "wiredId")]
	public string WiredId { get; set; } = string.Empty;

	/// <summary>
	/// Internal subnets used by the BGP peering between SDWAN and Meraki
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "internalSubnets")]
	public List<string> InternalSubnets { get; set; } = [];
}
