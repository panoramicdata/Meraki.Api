namespace Meraki.Api.Data;

/// <summary>
/// Source ports mirror configuration
/// </summary>
public class DeviceSwitchPortMirrorSource
{
	/// <summary>
	/// Source Port filter traffic based on vlans
	/// </summary>
	[DataMember(Name = "filter")]
	public DeviceSwitchPortMirrorFilter? Filter { get; set; }

	/// <summary>
	/// Array of all source ports config details
	/// </summary>
	[DataMember(Name = "ports")]
	public List<DeviceSwitchPortsMirrorPort>? Ports { get; set; }
}