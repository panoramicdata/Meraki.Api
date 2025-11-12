namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Vlans
/// </summary>
public interface IApplianceVlansSettings
{
	/// <summary>
	/// Returns the enabled status of VLANs for the network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/vlans/settings")]
	Task<VlansEnabledState> GetNetworkApplianceVlansSettingsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Enable/Disable VLANs for the given network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkVlansEnabledState"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/appliance/vlans/settings")]
	Task<VlansEnabledState> UpdateNetworkApplianceVlansSettingsAsync(
		string networkId,
		[Body] VlansEnabledState updateNetworkVlansEnabledState,
		CancellationToken cancellationToken = default
		);
}
