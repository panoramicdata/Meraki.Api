namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Latency By Network Item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesLatencyByNetworkItem
{
	/// <summary>
	/// Network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationWirelessDevicesLatencyByItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Overall latency metrics.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "overall")]
	public OrganizationWirelessDevicesLatencyByItemOverall Overall { get; set; } = new();
}
