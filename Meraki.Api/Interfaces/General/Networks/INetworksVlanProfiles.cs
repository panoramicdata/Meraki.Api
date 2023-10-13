namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksVlanProfiles

{
	/// <summary>
	/// Return an HTTP server for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="vlanProfileCreateRequest">The vlan profile creation request</param>
	[ApiOperationId("createNetworkVlanProfile")]
	[Post("/networks/{networkId}/vlanProfiles")]
	Task<VlanProfile> CreateNetworkVlanProfileAsync(
		string networkId,
		[Body] VlanProfileCreateRequest vlanProfileCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List VLAN profiles for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkVlanProfiles")]
	[Get("/networks/{networkId}/vlanProfiles")]
	Task<List<VlanProfile>> GetNetworkVlanProfilesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Get an existing VLAN profile of a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="iname">The iname for the Vlan profile</param>
	[ApiOperationId("getNetworkVlanProfile")]
	[Get("/networks/{networkId}/vlanProfiles/{iname}")]
	Task<VlanProfile> GetNetworkVlanProfileAsync(
		string networkId,
		string iname,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update an existing VLAN profile of a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="iname">The iname for the Vlan profile</param>
	/// <param name="vlanProfileUpdateRequest">The vlan profile update request</param>
	[ApiOperationId("updateNetworkVlanProfile")]
	[Put("/networks/{networkId}/vlanProfiles/{iname}")]
	Task<VlanProfile> UpdateNetworkVlanProfileAsync(
		string networkId,
		string iname,
		[Body] VlanProfileUpdateRequest vlanProfileUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a VLAN profile of a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="iname">The iname for the Vlan profile to delete</param>
	[ApiOperationId("deleteNetworkVlanProfile")]
	[Delete("/networks/{networkId}/vlanProfiles/{iname}")]
	Task DeleteNetworkVlanProfileAsync(
		string networkId,
		string iname,
		CancellationToken cancellationToken = default
		);
}
