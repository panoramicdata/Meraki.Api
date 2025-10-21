namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Interface for organization wireless MQTT settings operations
/// </summary>
public interface IOrganizationsWirelessMqtt
{
	/// <summary>
	/// Return MQTT Settings for networks
	/// GET /organizations/{organizationId}/wireless/mqtt/settings
	/// </summary>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 250. Default is 50.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="networkIds">Optional parameter to filter mqtt settings by network ID.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationWirelessMqttSettings")]
	[Get("/organizations/{organizationId}/wireless/mqtt/settings")]
	Task<OrganizationWirelessMqttSettingsResponse> GetOrganizationWirelessMqttSettingsAsync(
		string organizationId,
		int? perPage = null,
		string? startingAfter = null,
		string? endingBefore = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return MQTT Settings for networks (Internal API response version for pagination)
	/// GET /organizations/{organizationId}/wireless/mqtt/settings
	/// </summary>
	/// <param name="organizationId">The organization id</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page.</param>
	/// <param name="networkIds">Optional parameter to filter mqtt settings by network ID.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationWirelessMqttSettings")]
	[Get("/organizations/{organizationId}/wireless/mqtt/settings")]
	internal Task<ApiResponse<OrganizationWirelessMqttSettingsResponse>> GetOrganizationWirelessMqttSettingsApiResponseAsync(
		string organizationId,
		string? startingAfter = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Add new broker config for wireless MQTT
	/// PUT /organizations/{organizationId}/wireless/mqtt/settings
	/// </summary>
	/// <param name="organizationId">The organization id</param>
	/// <param name="request">The wireless MQTT settings to update</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("updateOrganizationWirelessMqttSettings")]
	[Put("/organizations/{organizationId}/wireless/mqtt/settings")]
	Task<OrganizationWirelessMqttSettings> UpdateOrganizationWirelessMqttSettingsAsync(
		string organizationId,
		[Body] OrganizationWirelessMqttSettingsUpdateRequest request,
		CancellationToken cancellationToken = default);
}
