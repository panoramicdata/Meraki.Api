namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Latency By Client Item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesLatencyByClientItem
{
	/// <summary>
	/// Device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "device")]
	public OrganizationWirelessDevicesLatencyByClientItemDevice Device { get; set; } = new();

	/// <summary>
	/// Network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationWirelessDevicesLatencyByClientItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Overall latency metrics.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "overall")]
	public OrganizationWirelessDevicesLatencyByClientItemOverall Overall { get; set; } = new();
}
