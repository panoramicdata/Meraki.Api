namespace Meraki.Api.Data;

/// <summary>
/// Catalyst access point information
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnectionsUnassignedItem
{
	/// <summary>
	/// ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// AP mac
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// AP model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// AP name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

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
	public OrganizationWirelessControllerConnectionsUnassignedItemController Controller { get; set; } = new();

	/// <summary>
	/// AP onboarding details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "onboarding")]
	public OrganizationWirelessControllerConnectionsUnassignedItemOnboarding Onboarding { get; set; } = new();

	/// <summary>
	/// Wireless LAN Controller tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public OrganizationWirelessControllerConnectionsUnassignedItemTags Tags { get; set; } = new();

	/// <summary>
	/// Catalyst access points details
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "details")]
	public List<OrganizationWirelessControllerConnectionsUnassignedItemDetail> Details { get; set; } = [];

	/// <summary>
	/// List of device uplink addresses information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uplinks")]
	public List<OrganizationWirelessControllerConnectionsUnassignedItemUplink> Uplinks { get; set; } = [];
}
