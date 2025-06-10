namespace Meraki.Api.Data;

/// <summary>
/// Version the device is upgrading to
/// </summary>
[DataContract]
public class OrganizationFirmwareUpgradesByDeviceItemUpgradeToVersion
{
	/// <summary>
	/// ID of the initial firmware version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Release date of the firmware version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "releaseDate")]
	public string ReleaseDate { get; set; } = string.Empty;

	/// <summary>
	/// Release type of the firmware version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "releaseType")]
	public string ReleaseType { get; set; } = string.Empty;

	/// <summary>
	/// Firmware version short name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "shortName")]
	public string ShortName { get; set; } = string.Empty;
}