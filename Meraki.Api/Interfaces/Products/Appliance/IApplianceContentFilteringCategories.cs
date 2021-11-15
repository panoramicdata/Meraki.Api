namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceContentFilteringCategories
{
	/// <summary>
	/// List all available content filtering categories for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceContentFilteringCategories")]
	[Get("/networks/{networkId}/appliance/contentFiltering/categories")]
	Task<ContentFilteringCategories> GetContentFilteringCategoriesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);
}
