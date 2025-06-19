namespace Meraki.Api.Data;

/// <summary>
/// The interface packet rates measured in packets per second
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceItemInterfaceReadingRate
{
	/// <summary>
	/// The rate of packets received during the timespan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "recv")]
	public int Recv { get; set; }

	/// <summary>
	/// The rate of packets sent during the timespan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "send")]
	public int Send { get; set; }

	/// <summary>
	/// The rate of all packets sent and received during the timespan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}