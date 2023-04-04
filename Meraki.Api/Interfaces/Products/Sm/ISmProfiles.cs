namespace Meraki.Api.Interfaces.Products.Sm;

public interface ISmProfiles
{
	/// <summary>
	/// List all profiles in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/sm/profiles")]
	Task<List<SmProfile>> GetNetworkSmProfilesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);
}
