namespace Meraki.Api.Data;

/// <summary>
/// Staged upgrade
/// </summary>
[DataContract]
public class OrganizationFirmwareUpgradesByDeviceItemUpgradeStaged
{
	/// <summary>
	/// The staged upgrade group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "group")]
	public OrganizationFirmwareUpgradesByDeviceItemUpgradeStagedGroup Group { get; set; } = new();
}
