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
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? PortId { get; set; }

	/// <summary>
	/// Switchport number
	/// </summary>
	[DataMember(Name = "portNum")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public int? PortNum { get; set; }

	/// <summary>
	/// Switchport name - a combination of switch name with port number
	/// </summary>
	[DataMember(Name = "portName")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? PortName { get; set; }

	/// <summary>
	/// The serial of parent node of the switchport
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Serial { get; set; }

	/// <summary>
	/// Profile attributes
	/// </summary>
	[DataMember(Name = "profile")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworksSwitchPortsProfileProfile? Profile { get; set; }
}
