namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices System CPU Load History
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesSystemCpuLoadHistoryNetwork
{
	/// <summary>
	/// The network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// List of custom tags for the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}
