namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsWirelessRadio
{
	/// <summary>
	/// List the AFC power limits of an organization by device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessRadioAfcPositionByDevice")]
	[Get("/organizations/{organizationId}/wireless/radio/afc/position/byDevice")]
	Task<List<OrganizationsWirelessRadioAfcPositionByDeviceItem>> GetOrganizationWirelessRadioAfcPositionByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// List the AFC power limits of an organization by device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessRadioAfcPowerLimitsByDevice")]
	[Get("/organizations/{organizationId}/wireless/radio/afc/powerLimits/byDevice")]
	Task<List<OrganizationsWirelessRadioAfcPowerLimitsByDeviceItem>> GetOrganizationWirelessRadioAfcPowerLimitsByDeviceAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
