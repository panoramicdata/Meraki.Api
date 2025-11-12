namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Wireless Radio
/// </summary>
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

	/// <summary>
	/// List the AutoRF settings of an organization by network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessRadioAutoRfByNetwork")]
	[Get("/organizations/{organizationId}/wireless/radio/autoRf/byNetwork")]
	Task<List<OrganizationsWirelessRadioAutoRfByNetworkItem>> GetOrganizationWirelessRadioAutoRfByNetworkAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// List the channel planning activities of an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessRadioAutoRfChannelsPlanningActivities")]
	[Get("/organizations/{organizationId}/wireless/radio/autoRf/channels/planning/activities")]
	Task<List<OrganizationsWirelessRadioAutoRfChannelsPlanningActivity>> GetOrganizationWirelessRadioAutoRfChannelsPlanningActivitiesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Recalculates automatically assigned channels for every AP within specified the specified network(s). Note: This could cause a brief loss in connectivity for wireless clients.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("recalculateOrganizationWirelessRadioAutoRfChannels")]
	[Post("/organizations/{organizationId}/wireless/radio/autoRf/channels/recalculate")]
	Task<
		OrganizationsWirelessRadioAutoRfChannelsRecalculateResponse> RecalculateOrganizationWirelessRadioAutoRfChannelsAsync(
			string organizationId,
			[Body] OrganizationsWirelessRadioAutoRfChannelsRecalculateRequest? request = null,
			CancellationToken cancellationToken = default
		);
}
