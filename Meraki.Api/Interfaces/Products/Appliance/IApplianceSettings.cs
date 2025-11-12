namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance
/// </summary>
public interface IApplianceSettings
{
	/// <summary>
	/// Return the appliance settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceSettings")]
	[Get("/networks/{networkId}/appliance/settings")]
	Task<ApplianceSettings> GetNetworkApplianceSettingsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the appliance settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="applianceSettings"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceSettings")]
	[Put("/networks/{networkId}/appliance/settings")]
	Task<ApplianceSettings> UpdateNetworkApplianceSettingsAsync(
		string networkId,
		[Body] ApplianceSettings applianceSettings,
		CancellationToken cancellationToken = default
		);
}
