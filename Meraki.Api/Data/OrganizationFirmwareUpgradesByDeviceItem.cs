namespace Meraki.Api.Data;

/// <summary>
/// Organization Firmware Upgrades By Device Item.
/// </summary>
[DataContract]
public class OrganizationFirmwareUpgradesByDeviceItem
{
	/// <summary>
	/// Status of the device upgrade
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceStatus")]
	public string DeviceStatus { get; set; } = string.Empty;

	/// <summary>
	/// Name assigned to the device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Serial of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// The devices upgrade details and status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upgrade")]
	public OrganizationFirmwareUpgradesByDeviceItemUpgrade Upgrade { get; set; } = new();
}
