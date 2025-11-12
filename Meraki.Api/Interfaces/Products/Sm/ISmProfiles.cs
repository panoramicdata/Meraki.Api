namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// I Sm Profiles
/// </summary>
public interface ISmProfiles
{
	/// <summary>
	/// List all the profiles in the network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/sm/profiles")]
	Task<List<SmProfile>> GetNetworkSmProfilesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);
}
