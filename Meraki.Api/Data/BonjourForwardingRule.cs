namespace Meraki.Api.Data;

/// <summary>
/// Rule3
/// </summary>
[DataContract]
public class BonjourForwardingRule
{
	/// <summary>
	/// A description for your Bonjour forwarding rule. Optional.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// The ID of the service VLAN. Required.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlanId")]
	public string VlanId { get; set; } = null!;

	/// <summary>
	/// A list of Bonjour services. At least one service must be specified. Available services are 'All Services', 'AirPlay', 'AFP', 'BitTorrent', 'FTP', 'iChat', 'iTunes', 'Printers', 'Samba', 'Scanners' and 'SSH'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "services")]
	public List<BonjourService> Services { get; set; } = [];
}
