namespace Meraki.Api.Data;

/// <summary>
/// Associated switch port details
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfileAssignedSwitchPort
{
	/// <summary>
	/// List of associated switchport numbers
	/// </summary> 
	[DataMember(Name = "portIds")]
	public List<string>? PortIds { get; set; }

	/// <summary>
	/// Switch details
	/// </summary>
	[DataMember(Name = "switch")]
	public NetworksSwitchPortsProfileSwitch? Switch { get; set; }

	/// <summary>
	/// Template details
	/// </summary>
	[DataMember(Name = "template")]
	public NetworksSwitchPortsProfileTemplate? Template { get; set; }
}
