namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksTrafficShapingApplicationCategories
{
	/// <summary>
	/// Returns the application categories for traffic shaping rules.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/trafficShaping/applicationCategories")]
	Task<Layer7ApplicationCategories> GetNetworkTrafficShapingApplicationCategoriesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);
}
