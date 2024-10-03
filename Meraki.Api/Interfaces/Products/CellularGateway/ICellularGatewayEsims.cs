namespace Meraki.Api.Interfaces.Products.CellularGateway;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICellularGatewayEsims
{
	/// <summary>
	/// The eSIM inventory of a given organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationCellularGatewayEsimsInventory")]
	[Get("/organizations/{organizationId}/cellularGateway/esims/inventory")]
	Task<NetworkCellularGatewayEsimsInventory> GetOrganizationCellularGatewayEsimsInventoryAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// The eSIM inventory of a given organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">The eSim Id</param>
	/// <param name="networkCellularGatewayEsimUpdate">The eSim update body</param>
	[ApiOperationId("updateOrganizationCellularGatewayEsimsInventory")]
	[Put("/organizations/{organizationId}/cellularGateway/esims/inventory/{id}")]
	Task<NetworkCellularGatewayEsimsInventoryItem> UpdateOrganizationCellularGatewayEsimsInventoryAsync(
		string organizationId,
		string id,
		[Body] NetworkCellularGatewayEsimUpdate networkCellularGatewayEsimUpdate,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Service providers customers can add accounts for.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationCellularGatewayEsimsServiceProviders")]
	[Get("/organizations/{organizationId}/cellularGateway/esims/serviceProviders")]
	Task<EsimsServiceProviders> GetOrganizationCellularGatewayEsimsServiceProvidersAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add a service provider account.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="networkCellularGatewayEsimCreateRequest">The creation request</param>
	[ApiOperationId("createOrganizationCellularGatewayEsimsServiceProvidersAccount")]
	[Post("/organizations/{organizationId}/cellularGateway/esims/serviceProviders/accounts")]
	Task<NetworkCellularGatewayEsimsServiceProviderAccount> CreateOrganizationCellularGatewayEsimsServiceProvidersAccountAsync(
		string organizationId,
		[Body] NetworkCellularGatewayEsimsServiceProviderAccountCreateRequest networkCellularGatewayEsimCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Inventory of service provider accounts tied to the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="accountIds">Optional parameter to filter the results by service provider account IDs.</param>
	[ApiOperationId("getOrganizationCellularGatewayEsimsServiceProvidersAccounts")]
	[Get("/organizations/{organizationId}/cellularGateway/esims/serviceProviders/accounts")]
	Task<EsimsServiceProvidersAccounts> GetOrganizationCellularGatewayEsimsServiceProvidersAccountsAsync(
		string organizationId,
		[AliasAs("accountIds[]")] List<int> accountIds,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Edit service provider account info stored in Meraki's database.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="accountId">Account ID</param>
	/// <param name="networkCellularGatewayEsimUpdateRequest">The update request</param>
	[ApiOperationId("createOrganizationCellularGatewayEsimsServiceProvidersAccount")]
	[Put("/organizations/{organizationId}/cellularGateway/esims/serviceProviders/accounts/{accountId}")]
	Task<NetworkCellularGatewayEsimsServiceProviderAccount> UpdateOrganizationCellularGatewayEsimsServiceProvidersAccountAsync(
		string organizationId,
		string accountId,
		[Body] NetworkCellularGatewayEsimsServiceProviderAccountUpdateRequest networkCellularGatewayEsimUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Remove a service provider account's integration with the Dashboard.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="accountId">Account ID</param>
	[ApiOperationId("deleteOrganizationCellularGatewayEsimsServiceProvidersAccount")]
	[Delete("/organizations/{organizationId}/cellularGateway/esims/serviceProviders/accounts/{accountId}")]
	Task DeleteOrganizationCellularGatewayEsimsServiceProvidersAccountAsync(
		string organizationId,
		string accountId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// The communication plans available for a given provider.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="accountIds">Account IDs that communication plans will be fetched for</param>
	[ApiOperationId("getOrganizationCellularGatewayEsimsServiceProvidersAccountsCommunicationPlans")]
	[Get("/organizations/{organizationId}/cellularGateway/esims/serviceProviders/accounts/communicationPlans")]
	Task<EsimsServiceProvidersAccountsCommunicationPlans> GetOrganizationCellularGatewayEsimsServiceProvidersAccountsCommunicationPlansAsync(
		string organizationId,
		[AliasAs("accountIds[]")] List<int> accountIds,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// The rate plans available for a given provider.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="accountIds">Account IDs that communication plans will be fetched for</param>
	[ApiOperationId("getOrganizationCellularGatewayEsimsServiceProvidersAccountsRatePlans")]
	[Get("/organizations/{organizationId}/cellularGateway/esims/serviceProviders/accounts/ratePlans")]
	Task<EsimsServiceProvidersAccountsRatePlans> GetOrganizationCellularGatewayEsimsServiceProvidersAccountsRatePlansAsync(
		string organizationId,
		[AliasAs("accountIds[]")] List<int> accountIds,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Swap which profile an eSIM uses.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="organizationCellularGatewayEsimSwapCreateRequest">The creation request</param>
	[ApiOperationId("createOrganizationCellularGatewayEsimsSwap")]
	[Post("/organizations/{organizationId}/cellularGateway/esims/swap")]
	Task<OrganizationCellularGatewayEsimSwapStatus> CreateOrganizationCellularGatewayEsimsSwapAsync(
		string organizationId,
		[Body] OrganizationCellularGatewayEsimSwapCreateRequest organizationCellularGatewayEsimSwapCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Get the status of a profile swap.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">eSIM EID</param>
	[ApiOperationId("updateOrganizationCellularGatewayEsimsSwap")]
	[Put("/organizations/{organizationId}/cellularGateway/esims/swap/{id}")]
	Task<OrganizationCellularGatewayEsimSwapStatus> UpdateOrganizationCellularGatewayEsimsSwapAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
		);
}
