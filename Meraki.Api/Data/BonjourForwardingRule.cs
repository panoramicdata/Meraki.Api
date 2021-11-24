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
	/// <value>A description for your Bonjour forwarding rule. Optional.</value>
	[DataMember(Name = "description")]
	public string Description { get; set; } = null!;

	/// <summary>
	/// The ID of the service VLAN. Required.
	/// </summary>
	/// <value>The ID of the service VLAN. Required.</value>
	[DataMember(Name = "vlanId")]
	public string VlanId { get; set; } = null!;

	/// <summary>
	/// A list of Bonjour services. At least one service must be specified. Available services are 'All Services', 'AirPlay', 'AFP', 'BitTorrent', 'FTP', 'iChat', 'iTunes', 'Printers', 'Samba', 'Scanners' and 'SSH'
	/// </summary>
	/// <value>A list of Bonjour services. At least one service must be specified. Available services are 'All Services', 'AirPlay', 'AFP', 'BitTorrent', 'FTP', 'iChat', 'iTunes', 'Printers', 'Samba', 'Scanners' and 'SSH'</value>
	[DataMember(Name = "services")]
	public List<string> Services { get; set; } = new();
}
