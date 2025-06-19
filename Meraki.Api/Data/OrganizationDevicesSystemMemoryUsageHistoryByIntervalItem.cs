namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices System Memory Usage History By Interval Item
/// </summary>
[DataContract]
public class OrganizationDevicesSystemMemoryUsageHistoryByIntervalItem
{
	/// <summary>
	/// The total RAM size provisioned on the device, in kB
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "provisioned")]
	public int Provisioned { get; set; }

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
	/// Information regarding memory availability on the device over the entire timespan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "free")]
	public OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemFree Free { get; set; } = new();

	/// <summary>
	/// Information regarding the network the device belongs to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Information regarding memory usage on the device over the entire timespan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "used")]
	public OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemUsed Used { get; set; } = new();

	/// <summary>
	/// Time interval snapshots of system memory utilization on the device with the most recent snapshot first
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "intervals")]
	public List<OrganizationDevicesSystemMemoryUsageHistoryByIntervalItemInterval> Intervals { get; set; } = [];
}
