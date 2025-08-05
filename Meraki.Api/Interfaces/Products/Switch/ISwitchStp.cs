namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchStp
{
	/// <summary>
	/// Returns STP settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/switch/stp")]
	Task<SwitchSettingsStp> GetNetworkSwitchStpAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates STP settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkSwitchSettingsStp"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/switch/stp")]
	Task<SwitchSettingsStp> UpdateNetworkSwitchStpAsync(
		string networkId,
		[Body] SwitchSettingsStp updateNetworkSwitchSettingsStp,
		CancellationToken cancellationToken = default
		);
}
