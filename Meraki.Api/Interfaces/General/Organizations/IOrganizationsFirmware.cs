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
}
