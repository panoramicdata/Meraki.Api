namespace Meraki.Api.Data;

/// <summary>
/// Organization Firmware Upgrades By Device Item.
/// </summary>
[DataContract]
public class OrganizationFirmwareUpgradesByDeviceItem
{
	/// <summary>
	/// The time the device checkin finished
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "checkinFinishedAt")]
	public DateTime CheckinFinishedAt { get; set; }

	/// <summary>
	/// The time the device checkin started
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "checkinStartedAt")]
	public DateTime CheckinStartedAt { get; set; }

	/// <summary>
	/// The detailed status of the device upgrade
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "detailedStatus")]
	public string DetailedStatus { get; set; } = string.Empty;

	/// <summary>
	/// Status of the device upgrade
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceStatus")]
	public string DeviceStatus { get; set; } = string.Empty;

	/// <summary>
	/// The time the device upgrade download finished
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downloadFinishedAt")]
	public DateTime DownloadFinishedAt { get; set; }

	/// <summary>
	/// The time the device upgrade download started
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downloadStartedAt")]
	public DateTime DownloadStartedAt { get; set; }

	/// <summary>
	/// The status of the device upgrade download
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downloadStatus")]
	public string DownloadStatus { get; set; } = string.Empty;

	/// <summary>
	/// The time the device upgrade install finished
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "installFinishedAt")]
	public DateTime InstallFinishedAt { get; set; }

	/// <summary>
	/// The time the device upgrade install started
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "installStartedAt")]
	public DateTime InstallStartedAt { get; set; }

	/// <summary>
	/// The status of the device upgrade install
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "installStatus")]
	public string InstallStatus { get; set; } = string.Empty;

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
	/// The time the device upgrade verification finished
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "verifyFinishedAt")]
	public DateTime VerifyFinishedAt { get; set; }

	/// <summary>
	/// The time the device upgrade verification started
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "verifyStartedAt")]
	public DateTime VerifyStartedAt { get; set; }

	/// <summary>
	/// The status of the device upgrade verification
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "verifyStatus")]
	public string VerifyStatus { get; set; } = string.Empty;

	/// <summary>
	/// The devices upgrade details and status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upgrade")]
	public OrganizationFirmwareUpgradesByDeviceItemUpgrade Upgrade { get; set; } = new();
}
