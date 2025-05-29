namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Topology Discovery By Device
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTopologyDiscoveryByDevice
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSwitchPortsTopologyDiscoveryByDeviceMetadata Meta { get; set; } = new();

	/// <summary>
	/// Switches
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsTopologyDiscoveryByDeviceItem> Items { get; set; } = [];
}
