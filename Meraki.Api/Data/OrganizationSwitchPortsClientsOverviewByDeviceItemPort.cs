namespace Meraki.Api.Data;

/// <summary>
/// Port Information
/// </summary>
[DataContract]
public class OrganizationSwitchPortsClientsOverviewByDeviceItemPort
{
	/// <summary>
	/// The string identifier of this port on the switch. This is commonly just the port number but may contain additional identifying information such as the slot and module-type if the port is located on a port module.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	/// <summary>
	/// Number of clients on the port in a given time.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchPortsClientsOverviewByDeviceItemPortCounts Counts { get; set; } = new();
}
