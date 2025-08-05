namespace Meraki.Api.Data;

/// <summary>
/// Load average measurement on the device
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesSystemCpuLoadHistorySeries
{
	/// <summary>
	/// 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cpuLoad5")]
	public int CpuLoad5 { get; set; }

	/// <summary>
	/// Timestamp of the cpu load measurement
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;
}