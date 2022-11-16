namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchPortsProfiles
{
	/// <summary>
	/// List the switch port profiles in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/switch/ports/profiles")]
	Task<List<SwitchPortsProfile>> GetNetworkSwitchPortsProfilesAsync(
		string networkId,
		CancellationToken cancellationToken = default);
}
