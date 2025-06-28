namespace Meraki.Api.Data;

/// <summary>
/// Cpu load data item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesSystemCpuLoadHistoryItem
{
	/// <summary>
	/// Number of CPU cores on the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cpuCount")]
	public int CpuCount { get; set; }

	/// <summary>
	/// MAC address of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Model of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Name of the device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Unique serial number for the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// List of custom tags for the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// Information regarding the network the device belongs to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationWirelessDevicesSystemCpuLoadHistoryNetwork Network { get; set; } = new();

	/// <summary>
	/// Series of cpu load average measurements on the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "series")]
	public List<OrganizationWirelessDevicesSystemCpuLoadHistorySeries> Series { get; set; } = [];
}
