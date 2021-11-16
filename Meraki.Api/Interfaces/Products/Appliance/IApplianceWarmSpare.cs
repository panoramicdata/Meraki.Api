namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceWarmSpare
{
	/// <summary>
	/// Return MX warm spare settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceWarmSpare")]
	[Get("/networks/{networkId}/appliance/warmSpare")]
	Task<WarmSpare> GetNetworkApplianceWarmSpareAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update MX warm spare settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateWarmSpare">Body for updating warm spare settings</param>
	[ApiOperationId("updateNetworkApplianceWarmSpare")]
	[Put("/networks/{networkId}/appliance/warmSpare")]
	Task<WarmSpare> UpdateNetworkApplianceWarmSpareAsync(
		[AliasAs("networkId")] string networkId,
		[Body] WarmSpareUpdateRequest updateWarmSpare,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Swap MX primary and warm spare appliances
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="warmSpare"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("swapNetworkApplianceWarmSpare")]
	[Post("/networks/{networkId}/appliance/warmSpare/swap")]
	Task<WarmSpare> SwapNetworkApplianceWarmSpareAsync(
		[AliasAs("networkId")] string networkId,
		[Body] WarmSpare warmSpare,
		CancellationToken cancellationToken = default
		);
}
