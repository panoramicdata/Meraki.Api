namespace Meraki.Api.Interfaces.General.Organizations;
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
}
