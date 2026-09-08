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
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<OrganizationWirelessMqttSettings>> GetOrganizationWirelessMqttSettingsAllAsync(
		this IOrganizationsWirelessMqtt organizationsWirelessMqtt,
		string organizationId,
		List<string>? networkIds = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllFromResponsePropertyAsync(
			(startingAfter, _, cancellationToken) =>
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
