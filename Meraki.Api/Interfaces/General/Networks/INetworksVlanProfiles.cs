namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksVlanProfiles

{
	/// <summary>
	/// Create a Vlan profile on a network
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
	/// Update the assigned VLAN Profile for devices in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="vlanProfileReassignmentRequest">The vlan profile reassignment request</param>
	[ApiOperationId("reassignNetworkVlanProfilesAssignments")]
	[Post("/networks/{networkId}/vlanProfiles/assignments/reassign")]
	Task<VlanProfileAssignment> ReassignNetworkVlanProfilesAssignmentsAsync(
		string networkId,
		[Body] VlanProfileReassignmentRequest vlanProfileReassignmentRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Get the assigned VLAN Profiles for devices in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="serials">Optional parameter to filter devices by serials. All devices returned belong to serial numbers that are an exact match.</param>
	/// <param name="productTypes">Optional parameter to filter devices by product types.</param>
	/// <param name="stackIds">Optional parameter to filter devices by Switch Stack ids.</param>
	[ApiOperationId("getNetworkVlanProfilesAssignmentsByDevice")]
	[Get("/networks/{networkId}/vlanProfiles/assignments/byDevice")]
	Task<List<VlanProfileDeviceAssignment>> GetNetworkVlanProfilesAssignmentsByDeviceAsync(
		string networkId,
		int? perPage = 1000,
		string? startingAfter = null,
		string? endingBefore = null,
		[AliasAs("serials[]")] List<string>? serials = null,
		[AliasAs("productTypes[]")] List<string>? productTypes = null,
		[AliasAs("stackIds[]")] List<string>? stackIds = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	///  For use by GetNetworkVlanProfilesAssignmentsByDeviceAllAsync
	/// </summary>
	[Get("/networks/{networkId}/vlanProfiles/assignments/byDevice")]
	internal Task<ApiResponse<List<VlanProfileDeviceAssignment>>> GetNetworkVlanProfilesAssignmentsByDeviceApiResponseAsync(
		string networkId,
		string? startingAfter,
		[AliasAs("serials[]")] List<string>? serials = null,
		[AliasAs("productTypes[]")] List<string>? productTypes = null,
		[AliasAs("stackIds[]")] List<string>? stackIds = null,
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
