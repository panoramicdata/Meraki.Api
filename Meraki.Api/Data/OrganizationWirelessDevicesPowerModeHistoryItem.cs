namespace Meraki.Api.Data;

/// <summary>
/// Power mode data item
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesPowerModeHistoryItem
{
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
	public OrganizationWirelessDevicesPowerModeHistoryNetwork Network { get; set; } = new();

	/// <summary>
	/// Events indicating power mode changes for the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "events")]
	public List<OrganizationWirelessDevicesPowerModeHistoryEvent> Events { get; set; } = [];
}
