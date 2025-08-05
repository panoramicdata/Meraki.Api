namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessEthernetPortsProfiles
{
	/// <summary>
	/// Create an AP port profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="wirelessEthernetPortsProfileCreateRequest">The request body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createNetworkWirelessEthernetPortsProfile")]
	[Post("/networks/{networkId}/wireless/ethernet/ports/profiles")]
	Task<WirelessEthernetPortsProfile> CreateNetworkWirelessEthernetPortsProfileAsync(
		string networkId,
		[Body] WirelessEthernetPortsProfileCreateRequest wirelessEthernetPortsProfileCreateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Assign AP port profile to list of APs
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="wirelessEthernetPortsProfileAssign">The request body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("assignNetworkWirelessEthernetPortsProfiles")]
	[Post("/networks/{networkId}/wireless/ethernet/ports/profiles/assign")]
	Task<WirelessEthernetPortsProfileAssign> AssignNetworkWirelessEthernetPortsProfilesAsync(
		string networkId,
		[Body] WirelessEthernetPortsProfileAssign wirelessEthernetPortsProfileAssign,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Set the AP port profile to be default for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="wirelessEthernetPortsProfileSetDefault">The request body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("setNetworkWirelessEthernetPortsProfilesDefault")]
	[Post("/networks/{networkId}/wireless/ethernet/ports/profiles/setDefault")]
	Task<WirelessEthernetPortsProfileSetDefault> SetNetworkWirelessEthernetPortsProfilesDefaultAsync(
		string networkId,
		[Body] WirelessEthernetPortsProfileSetDefault wirelessEthernetPortsProfileSetDefault,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the AP port profiles for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkWirelessEthernetPortsProfiles")]
	[Get("/networks/{networkId}/wireless/ethernet/ports/profiles")]
	Task<List<WirelessEthernetPortsProfile>> GetNetworkWirelessEthernetPortsProfilesAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Show the AP port profile by ID for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="profileId">The profile id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkWirelessEthernetPortsProfile")]
	[Get("/networks/{networkId}/wireless/ethernet/ports/profiles/{profileId}")]
	Task<WirelessEthernetPortsProfile> GetNetworkWirelessEthernetPortsProfileAsync(
		string networkId,
		string profileId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Show the AP port profile by ID for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="profileId">The profile id</param>
	/// <param name="wirelessEthernetPortsProfileUpdateRequest">The request body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkWirelessEthernetPortsProfile")]
	[Put("/networks/{networkId}/wireless/ethernet/ports/profiles/{profileId}")]
	Task<WirelessEthernetPortsProfile> UpdateNetworkWirelessEthernetPortsProfileAsync(
		string networkId,
		string profileId,
		[Body] WirelessEthernetPortsProfileUpdateRequest wirelessEthernetPortsProfileUpdateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete an AP port profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="profileId">The profile id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteNetworkWirelessEthernetPortsProfile")]
	[Delete("/networks/{networkId}/wireless/ethernet/ports/profiles/{profileId}")]
	Task DeleteNetworkWirelessEthernetPortsProfileAsync
	(
		string networkId,
		string profileId,
		CancellationToken cancellationToken = default
		);
}
