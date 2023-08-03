namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceRfProfiles
{
	/// <summary>
	/// List the RF profiles for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceRfProfiles")]
	[Get("/networks/{networkId}/appliance/rfProfiles")]
	Task<NetworkApplianceRfProfiles> GetNetworkApplianceRfProfiles(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a RF profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="rfProfileId">Rf profile ID</param>
	[ApiOperationId("getNetworkApplianceRfProfile")]
	[Get("/networks/{networkId}/appliance/rfProfiles/{rfProfileId}")]
	Task<NetworkApplianceRfProfile> GetNetworkApplianceRfProfile(
		string networkId,
		string rfProfileId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Creates new RF profile for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="networkApplianceRfProfileCreateUpdate">The RF Propfile update request</param>
	[ApiOperationId("createNetworkApplianceRfProfile")]
	[Post("/networks/{networkId}/appliance/rfProfiles")]
	Task<NetworkApplianceRfProfile> CreateNetworkApplianceRfProfile(
		string networkId,
		[Body] NetworkApplianceRfProfileCreateUpdate networkApplianceRfProfileCreateUpdate,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates specified RF profile for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="rfProfileId">Rf Profile ID</param>
	/// <param name="networkApplianceRfProfileCreateUpdate">The RF Propfile update request</param>
	[ApiOperationId("updateNetworkApplianceRfProfile")]
	[Put("/networks/{networkId}/appliance/rfProfiles/{rfProfileId}")]
	Task<NetworkApplianceRfProfile> UpdateNetworkApplianceRfProfile(
		string networkId,
		string rfProfileId,
		[Body] NetworkApplianceRfProfileCreateUpdate networkApplianceRfProfileCreateUpdate,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a RF Profile
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="rfProfileId">The rf Profile id</param>
	[Delete("/networks/{networkId}/appliance/rfProfiles/{rfProfileId}")]
	Task DeleteNetworkApplianceRfProfile(
		string networkId,
		string rfProfileId,
		CancellationToken cancellationToken = default);
}
