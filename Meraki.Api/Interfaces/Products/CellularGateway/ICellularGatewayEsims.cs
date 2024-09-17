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
	[ApiOperationId("createOrganizationCellularGatewayEsimsServiceProvidersAccount")]
	[Post("/organizations/{organizationId}/cellularGateway/esims/serviceProviders/accounts")]
	Task<NetworkCellularGatewayEsimsServiceProviderAccount> CreateOrganizationCellularGatewayEsimsServiceProvidersAccountAsync(
		string organizationId,
		[Body] NetworkCellularGatewayEsimsServiceProviderAccountCreateRequest networkCellularGatewayEsimUpdate
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
}
