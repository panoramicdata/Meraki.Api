namespace Meraki.Api.Data;

/// <summary>
/// The devices upgrade details and status
/// </summary>
[DataContract]
public class OrganizationFirmwareUpgradesByDeviceItemUpgrade
{
	/// <summary>
	/// ID of the upgrade
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Status of the upgrade
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Start time of the upgrade
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "time")]
	public string Time { get; set; } = string.Empty;

	/// <summary>
	/// ID of the upgrade batch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upgradeBatchId")]
	public string UpgradeBatchId { get; set; } = string.Empty;

	/// <summary>
	/// The initial version of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fromVersion")]
	public OrganizationFirmwareUpgradesByDeviceItemUpgradeFromVersion FromVersion { get; set; } = new();

	/// <summary>
	/// Staged upgrade
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "staged")]
	public OrganizationFirmwareUpgradesByDeviceItemUpgradeStaged Staged { get; set; } = new();

	/// <summary>
	/// Version the device is upgrading to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "toVersion")]
	public OrganizationFirmwareUpgradesByDeviceItemUpgradeToVersion ToVersion { get; set; } = new();
}
