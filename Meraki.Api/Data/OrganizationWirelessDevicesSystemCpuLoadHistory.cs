namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices System CPU Load History
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesSystemCpuLoadHistory
{
	/// <summary>
	/// The top-level property containing all cpu load data.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessDevicesSystemCpuLoadHistoryItem> Items { get; set; } = [];
}
