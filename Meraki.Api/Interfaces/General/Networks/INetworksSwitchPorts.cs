namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksSwitchPorts
{
	/// <summary>
	/// List the port profiles in a network
	/// </summary>
	/// <param name="networkId">Network ID</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[Get("/networks/{networkId}/switch/ports/profiles")]
	Task<List<NetworksSwitchPortsProfile>> GetNetworkSwitchPortsProfilesAsync(
		string networkId,
		CancellationToken cancellationToken = default);
}
