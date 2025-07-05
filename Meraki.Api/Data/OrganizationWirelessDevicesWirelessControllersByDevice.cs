namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Devices Wireless Controllers By Device
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesWirelessControllersByDevice
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessDevicesWirelessControllersByDeviceMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of Catalyst access points information
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessDevicesWirelessControllersByDeviceItem> Items { get; set; } = [];
}

/// <summary>
/// Access Point Information
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesWirelessControllersByDeviceItem
{
	/// <summary>
	/// Country code (2 characters)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "countryCode")]
	public string CountryCode { get; set; } = string.Empty;

	/// <summary>
	/// The time when AP joins wireless controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "joinedAt")]
	public string JoinedAt { get; set; } = string.Empty;

	/// <summary>
	/// AP mode (local, flex, etc.)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string Mode { get; set; } = string.Empty;

	/// <summary>
	/// AP model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// AP cloud ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Associated wireless controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "controller")]
	public OrganizationWirelessDevicesWirelessControllersByDeviceController Controller { get; set; } = new();

	/// <summary>
	/// Catalyst access point network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationWirelessDevicesWirelessControllersByDeviceNetwork Network { get; set; } = new();

	/// <summary>
	/// Catalyst access point details
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "details")]
	public List<OrganizationWirelessDevicesWirelessControllersByDeviceDetail> Details { get; set; } = [];

	/// <summary>
	/// The tags of the catalyst access point
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<OrganizationWirelessDevicesWirelessControllersByDeviceTag> Tags { get; set; } = [];
}
