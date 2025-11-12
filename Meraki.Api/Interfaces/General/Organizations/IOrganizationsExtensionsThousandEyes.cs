namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Extensions Thousand Eyes
/// </summary>
public interface IOrganizationsExtensionsThousandEyes
{
	/// <summary>
	/// List the ThousandEyes agent configurations under this organization. Only valid for networks with access to Meraki Insight. Organization must have a ThousandEyes account connected to perform this action.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationExtensionsThousandEyesNetworks")]
	[Get("/organizations/{organizationId}/extensions/thousandEyes/networks")]
	Task<List<ThousandEyesNetwork>> GetOrganizationExtensionsThousandEyesNetworksAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Add a ThousandEyes agent for this network. Only valid for networks with access to Meraki Insight. Organization must have a ThousandEyes account connected to perform this action.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationExtensionsThousandEyesNetwork")]
	[Post("/organizations/{organizationId}/extensions/thousandEyes/networks")]
	Task<ThousandEyesNetwork> CreateOrganizationExtensionsThousandEyesNetworkAsync(string organizationId, [Body] ThousandEyesNetworkCreateRequest request, CancellationToken cancellationToken = default);

	/// <summary>
	/// List the ThousandEyes agent configuration under this network. Only valid for networks with access to Meraki Insight. Organization must have a ThousandEyes account connected to perform this action.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationExtensionsThousandEyesNetwork")]
	[Get("/organizations/{organizationId}/extensions/thousandEyes/networks/{networkId}")]
	Task<ThousandEyesNetwork> GetOrganizationExtensionsThousandEyesNetworkAsync(
		string organizationId,
		string networkId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Update a ThousandEyes agent from this network. Only valid for networks with access to Meraki Insight. Organization must have a ThousandEyes account connected to perform this action.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="networkId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationExtensionsThousandEyesNetwork")]
	[Put("/organizations/{organizationId}/extensions/thousandEyes/networks/{networkId}")]
	Task<ThousandEyesNetwork> UpdateOrganizationExtensionsThousandEyesNetworkAsync(
		string organizationId,
		string networkId,
		[Body] ThousandEyesNetworkUpdateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Delete a ThousandEyes agent from this network. Only valid for networks with access to Meraki Insight. Organization must have a ThousandEyes account connected to perform this action.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationExtensionsThousandEyesNetwork")]
	[Delete("/organizations/{organizationId}/extensions/thousandEyes/networks/{networkId}")]
	Task DeleteOrganizationExtensionsThousandEyesNetworkAsync(
		string organizationId,
		string networkId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Create a ThousandEyes test based on a provided test template. Only valid for networks with access to Meraki Insight. Organization must have a ThousandEyes account connected to perform this action.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="networkId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationExtensionsThousandEyesTest")]
	[Post("/organizations/{organizationId}/extensions/thousandEyes/tests")]
	Task<ThousandEyesCreateTestResponse> CreateOrganizationExtensionsThousandEyesTestAsync(
		string organizationId,
		string networkId,
		[Body] ThousandEyesTestCreateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// List the ThousandEyes agent configurations under this organization. Only valid for networks with access to Meraki Insight. Organization must have a ThousandEyes account connected to perform this action.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationExtensionsThousandEyesNetworksSupported")]
	[Get("/organizations/{organizationId}/extensions/thousandEyes/networks/supported")]
	Task<List<ThousandEyesNetworkSupported>> GetOrganizationExtensionsThousandEyesNetworksSupportedAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
