namespace Meraki.Api.Data;

/// <summary>
/// The status of a packet counter on the interfaces of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceItemInterfaceReading
{
	/// <summary>
	/// The total count of packets received by the interface during the timespan 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "recv")]
	public int Recv { get; set; }

	/// <summary>
	/// The total count of packets sent by the interface during the timespan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "send")]
	public int Send { get; set; }

	/// <summary>
	/// The total count of sent and received packets during the timespan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// The type of packets being counted
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The interface packet rates measured in packets per second
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rate")]
	public OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceItemInterfaceReadingRate Rate { get; set; } = new();
}
