namespace Meraki.Api.Data;

/// <summary>
/// Switches
/// </summary>
[DataContract]
public class SwitchPortsTopologyDiscoveryByDevice
	: ItemsResponseWithMeta<SwitchPortsTopologyDiscoveryByDeviceItem>
{
	/// <summary>
	/// Switches
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public override List<SwitchPortsTopologyDiscoveryByDeviceItem> Items { get; set; } = [];

}
