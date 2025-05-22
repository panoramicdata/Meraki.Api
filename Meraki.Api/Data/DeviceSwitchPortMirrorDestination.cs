namespace Meraki.Api.Data;

/// <summary>
/// Destination port mirror configuration
/// </summary>
[DataContract]
public class DeviceSwitchPortMirrorDestination
{
	/// <summary>
	/// Transit or destination vlan only for RSPAN
	/// </summary>
	[DataMember(Name = "vlan")]
	public string? Vlan { get; set; }

	/// <summary>
	/// Destination port config details
	/// </summary>
	[DataMember(Name = "port")]
	public DeviceSwitchPortsMirrorPort? Port { get; set; }
}
