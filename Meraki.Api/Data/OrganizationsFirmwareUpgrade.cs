namespace Meraki.Api.Data;

/// <summary>
/// Organizations Firmware Upgrade
/// </summary>
[DataContract]
public class OrganizationsFirmwareUpgrade
{
	/// <summary>
	/// Timestamp when upgrade completed. Null if status pending.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "completedAt")]
	public string CompletedAt { get; set; } = string.Empty;

	/// <summary>
	/// product upgraded [wireless, appliance, switch, systemsManager, camera, cellularGateway, sensor]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productTypes")]
	public string ProductTypes { get; set; } = string.Empty;

	/// <summary>
	/// Status of upgrade event: [Cancelled, Completed]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Scheduled start time
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "time")]
	public string Time { get; set; } = string.Empty;

	/// <summary>
	/// The upgrade batch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upgradeBatchId")]
	public string UpgradeBatchId { get; set; } = string.Empty;

	/// <summary>
	/// The upgrade
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upgradeId")]
	public string UpgradeId { get; set; } = string.Empty;

	/// <summary>
	/// ID of the upgrade's starting version
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "fromVersion")]
	public OrganizationsFirmwareUpgradeFromVersion FromVersion { get; set; } = new();

	/// <summary>
	/// Network of the upgrade
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationsFirmwareUpgradeNetwork Network { get; set; } = new();

	/// <summary>
	/// ID of the upgrade's target version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "toVersion")]
	public OrganizationsFirmwareUpgradeToVersion ToVersion { get; set; } = new();
}
