namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsFirmware
{
	/// <summary>
	/// Get firmware upgrade information for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationFirmwareUpgrades")]
	[Get("/organizations/{organizationId}/firmware/upgrades")]
	Task<List<OrganizationsFirmwareUpgrade>> GetOrganizationsFirmwareUpgradesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get firmware upgrade status for the filtered devices. This endpoint currently only supports Meraki switches.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationFirmwareUpgradesByDevice")]
	[Get("/organizations/{organizationId}/firmware/upgrades/byDevice")]
	Task<List<OrganizationFirmwareUpgradesByDeviceItem>> GetOrganizationFirmwareUpgradesByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
