namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceSingleLan
{
	/// <summary>
	/// Return single LAN configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceSingleLan")]
	[Get("/networks/{networkId}/appliance/singleLan")]
	Task<LanConfiguration> GetNetworkApplianceSingleLanAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update single LAN configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkApplianceSingleLan">Body for updating a single LAN config</param>
	[ApiOperationId("updateNetworkApplianceSingleLan")]
	[Put("/networks/{networkId}/appliance/singleLan")]
	Task<LanConfiguration> UpdateNetworkApplianceSingleLanAsync(
		[AliasAs("networkId")] string networkId,
		[Body] LanConfigurationUpdateRequest updateNetworkApplianceSingleLan,
		CancellationToken cancellationToken = default
		);
}
