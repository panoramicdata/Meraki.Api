namespace Meraki.Api.Data;

/// <summary>
/// ID of the upgrade's starting version
/// </summary>
[DataContract]
public class OrganizationsFirmwareUpgradeFromVersion
{
	/// <summary>
	/// Firmware name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "firmware")]
	public string Firmware { get; set; } = string.Empty;

	/// <summary>
	/// Firmware version ID
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
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "shortName")]
	public string ShortName { get; set; } = string.Empty;
}