using Meraki.Api.Data;

namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for IOrganizationsWirelessMqtt
/// </summary>
public static class IOrganizationsWirelessMqttExtensions
{
	/// <summary>
	/// Get all MQTT settings for networks in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationsWirelessMqtt">The IOrganizationsWirelessMqtt instance</param>
	/// <param name="organizationId">The organization id</param>
	/// <param name="networkIds">Optional parameter to filter mqtt settings by network ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	public static Task<List<OrganizationWirelessMqttSettings>> GetOrganizationWirelessMqttSettingsAllAsync(
		this IOrganizationsWirelessMqtt organizationsWirelessMqtt,
		string organizationId,
		List<string>? networkIds = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllFromResponsePropertyAsync(
			(startingAfter, endingBefore, cancellationToken) =>
				organizationsWirelessMqtt.GetOrganizationWirelessMqttSettingsApiResponseAsync(
					organizationId,
					startingAfter,
					networkIds,
					cancellationToken
				),
			(response) => response.Content?.Items ?? [],
			cancellationToken
		);
}
