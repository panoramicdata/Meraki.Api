namespace Meraki.Api.Data;

/// <summary>
/// Port statuses of a switch
/// </summary>
[DataContract]
public class SwitchPortsStatusesBySwitch
{
	/// <summary>
	/// The MAC address of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// The model of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string? Model { get; set; }

	/// <summary>
	/// The name of the switch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The serial number of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Identifying information of the switch's network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public SwitchPortsStatusesBySwitchNetwork? Network { get; set; }

	/// <summary>
	/// The statuses of the ports on the switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<SwitchPortStatus>? Ports { get; set; }
}
