namespace Meraki.Api.Data;

/// <summary>
/// A port configured with port profile
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfileAssociatedPort
{
	/// <summary>
	/// The ID of the switchport
	/// </summary>
	[DataMember(Name = "portId")]
	public string? PortId { get; set; }

	/// <summary>
	/// Switchport number
	/// </summary>
	[DataMember(Name = "portNum")]
	public int? PortNum { get; set; }

	/// <summary>
	/// Switchport name - a combination of switch name with port number
	/// </summary>
	[DataMember(Name = "portName")]
	public string? PortName { get; set; }

	/// <summary>
	/// The serial of parent node of the switchport
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Profile attributes
	/// </summary>
	[DataMember(Name = "profile")]
	public NetworksSwitchPortsProfileProfile? Profile { get; set; }
}
