namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller redundancy information
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceRedundancy
{
	/// <summary>
	/// Wireless LAN controller chassis name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "chassisName")]
	public string ChassisName { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller redundancy ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller redundant device serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "redundantSerial")]
	public string RedundantSerial { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller role(Active, Active recovery, Standby hot, Standby recovery and Offline)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "role")]
	public string Role { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller redundancy management interface information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "management")]
	public OrganizationWirelessControllerOverviewByDeviceRedundancyManagement Management { get; set; } = new();
}
