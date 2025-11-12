namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Content Filtering Categories
/// </summary>
public interface IApplianceContentFilteringCategories
{
	/// <summary>
	/// List all available content filtering categories for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceContentFilteringCategories")]
	[Get("/networks/{networkId}/appliance/contentFiltering/categories")]
	Task<ContentFilteringCategories> GetNetworkApplianceContentFilteringCategoriesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);
}
