namespace Meraki.Api.Data;

/// <summary>
/// SwitchPort
/// </summary>
[DataContract]
public class LinkAggregationSwitchPort
{
	/// <summary>
	/// Serial number of the switch.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Port identifier of switch port. For modules, the identifier is "SlotNumber_ModuleType_PortNumber" (Ex: "1_8X10G_1"), otherwise it is just the port number (Ex: "8").
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty!;
}
