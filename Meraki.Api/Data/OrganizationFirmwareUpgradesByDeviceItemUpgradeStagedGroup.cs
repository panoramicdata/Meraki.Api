namespace Meraki.Api.Data;

/// <summary>
/// The staged upgrade group
/// </summary>
[DataContract]
public class OrganizationFirmwareUpgradesByDeviceItemUpgradeStagedGroup
{
	/// <summary>
	/// Id of the staged upgrade group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}