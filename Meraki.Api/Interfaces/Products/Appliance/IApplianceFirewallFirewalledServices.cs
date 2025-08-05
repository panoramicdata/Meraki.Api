namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceFirewallFirewalledServices
{
	/// <summary>
	/// List the appliance services and their accessibility rules
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/firewall/firewalledServices")]
	Task<List<FirewalledService>> GetNetworkApplianceFirewallFirewalledServicesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the accessibility settings of the given service
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="service">The serviceType</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/firewall/firewalledServices/{service}")]
	Task<List<FirewalledService>> GetNetworkApplianceFirewallFirewalledServiceAsync(
		string networkId,
		FirewalledServiceType service,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates the accessibility settings for the given service
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="service">The service</param>
	/// <param name="firewalledService"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/appliance/firewall/firewalledServices/{service}")]
	Task<List<FirewalledService>> UpdateNetworkApplianceFirewallFirewalledServiceAsync(
		string networkId,
		FirewalledServiceType service,
		[Body] FirewalledService firewalledService,
		CancellationToken cancellationToken = default
		);
}
