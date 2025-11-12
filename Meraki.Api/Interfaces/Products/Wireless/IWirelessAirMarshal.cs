namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// I Wireless Air Marshal
/// </summary>
public interface IWirelessAirMarshal
{
	/// <summary>
	/// List Air Marshal scan results from a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 7 days. (optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/airMarshal")]
	Task<List<AirMarshal>> GetNetworkWirelessAirMarshalAsync(
		string networkId,
		string t0 = null!,
		double? timespan = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Returns the current Air Marshal rules for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="networkIds">(optional) The set of network IDs to include.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationWirelessAirMarshalRules")]
	[Get("/organizations/{organizationId}/wireless/airMarshal/rules")]
	Task<AirMarshalRules> GetOrganizationWirelessAirMarshalRulesAsync(
		string organizationId,
		[AliasAs("networkIds[]")] List<string>? networkIds,
		int? perPage,
		string? startingAfter,
		string? endingBefore,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a rule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">Network ID</param>
	/// <param name="ruleId">Rule ID.</param>
	/// <param name="airMarshalRuleUpdateRequest">The update request</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("updateNetworkWirelessAirMarshalRule")]
	[Put("/networks/{networkId}/wireless/airMarshal/rules/{ruleId}")]
	Task<AirMarshalRulesItem> UpdateNetworkWirelessAirMarshalRuleAsync(
		string networkId,
		string ruleId,
		[Body] AirMarshalRuleCreateUpdateRequest airMarshalRuleUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Creates a new rule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">Network ID</param>
	/// <param name="airMarshalRuleUpdateRequest">The update request</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("createNetworkWirelessAirMarshalRule")]
	[Post("/networks/{networkId}/wireless/airMarshal/rules")]
	Task<AirMarshalRulesItem> CreateNetworkWirelessAirMarshalRuleAsync(
		string networkId,
		[Body] AirMarshalRuleCreateUpdateRequest airMarshalRuleUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete an Air Marshal rule.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">Network ID</param>
	/// <param name="ruleId">Rule ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("deleteNetworkWirelessAirMarshalRule")]
	[Delete("/networks/{networkId}/wireless/airMarshal/rules/{ruleId}")]
	Task DeleteNetworkWirelessAirMarshalRuleAsync(
		string networkId,
		string ruleId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates Air Marshal settings.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">Network ID</param>
	/// <param name="airMarshalSettingsUpdateRequest">The update request</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("updateNetworkWirelessAirMarshalSettings")]
	[Put("/networks/{networkId}/wireless/airMarshal/settings")]
	Task<AirMarshalSettings> UpdateNetworkWirelessAirMarshalSettingsAsync(
		string networkId,
		[Body] AirMarshalSettingsUpdateRequest airMarshalSettingsUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Returns the current Air Marshal settings for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="networkIds">(optional) The set of network IDs to include.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationWirelessAirMarshalSettingsByNetwork")]
	[Get("/organizations/{organizationId}/wireless/airMarshal/settings/byNetwork")]
	Task<AirMarshalSettingsByNetwork> GetOrganizationWirelessAirMarshalSettingsByNetworkAsync(
		string organizationId,
		[AliasAs("networkIds[]")] List<string>? networkIds,
		int? perPage,
		string? startingAfter,
		string? endingBefore,
		CancellationToken cancellationToken = default
		);
}
