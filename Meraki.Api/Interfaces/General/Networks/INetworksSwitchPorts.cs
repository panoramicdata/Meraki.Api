namespace Meraki.Api.Interfaces.General.Networks;
/// <summary>
/// I Networks Switch Ports
/// </summary>
public interface INetworksSwitchPorts
{
	/// <summary>
	/// List the port profiles in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">Network ID</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[ApiOperationId("getNetworkSwitchPortsProfiles")]
	[Get("/networks/{networkId}/switch/ports/profiles")]
	Task<List<NetworksSwitchPortsProfile>> GetNetworkSwitchPortsProfilesAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a port profile in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">Network ID</param>
	/// <param name="networksSwitchPortsProfile"></param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[ApiOperationId("createNetworkSwitchPortsProfile")]
	[Post("/networks/{networkId}/switch/ports/profiles")]
	Task<NetworksSwitchPortsProfile> CreateNetworkSwitchPortsProfileAsync(
		string networkId,
		[Body] NetworksSwitchPortsProfileCreateRequest networksSwitchPortsProfile,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a port profile in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">Network ID</param>
	/// <param name="id">Id of swith port profile</param>
	/// <param name="networksSwitchPortsProfile"></param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[ApiOperationId("updateNetworkSwitchPortsProfile")]
	[Put("/networks/{networkId}/switch/ports/profiles/{id}")]
	Task<NetworksSwitchPortsProfile> UpdateNetworkSwitchPortsProfileAsync(
		string networkId,
		string id,
		[Body] NetworksSwitchPortsProfileUpdateRequest networksSwitchPortsProfile,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a port profile from a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">Network ID</param>
	/// <param name="id">Id of swith port profile</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[ApiOperationId("deleteNetworkSwitchPortsProfile")]
	[Delete("/networks/{networkId}/switch/ports/profiles/{id}")]
	Task<string> DeleteNetworkSwitchPortsProfileAsync(
		string networkId,
		string id,
		CancellationToken cancellationToken = default);
}
