namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceFirewallSettings
{
	/// <summary>
	/// Return the firewall settings for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/appliance/firewall/settings")]
	Task<ApplianceFirewallSettings> GetNetworkApplianceFirewallSettingsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the cellular firewall rules of an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="ApplianceFirewallSettingsUpdateRequest">Body for updating the appliance firewall settings</param>
	[Put("/networks/{networkId}/appliance/firewall/settings")]
	Task<ApplianceFirewallSettings> UpdateNetworkApplianceFirewallSettingsAsync(
		string networkId,
		[Body] ApplianceFirewallSettingsUpdateRequest applianceFirewallSettingsUpdateRequest,
		CancellationToken cancellationToken = default
		);
}
