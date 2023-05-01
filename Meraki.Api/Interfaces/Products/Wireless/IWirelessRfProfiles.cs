namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessRfProfiles
{
	/// <summary>
	/// Creates new RF profile for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkWirelessRfProfile">Body for creating an RF profile</param>
	[Post("/networks/{networkId}/wireless/rfProfiles")]
	Task<WirelessRfProfile> CreateNetworkWirelessRfProfileAsync(
		string networkId,
		[Body] WirelessRfProfileCreateUpdateRequest createNetworkWirelessRfProfile,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a RF Profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="rfProfileId">The RF profile id</param>
	[Delete("/networks/{networkId}/wireless/rfProfiles/{rfProfileId}")]
	Task DeleteNetworkWirelessRfProfileAsync(
		string networkId,
		string rfProfileId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a RF profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="rfProfileId">The RF profile id</param>
	[Get("/networks/{networkId}/wireless/rfProfiles/{rfProfileId}")]
	Task<WirelessRfProfile> GetNetworkWirelessRfProfileAsync(
		string networkId,
		string rfProfileId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the non-basic RF profiles for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="includeTemplateProfiles">If the network is bound to a template, this parameter controls whether or not the non-basic RF profiles defined on the template     should be included in the response alongside the non-basic profiles defined on the bound network. Defaults to false.  (optional)</param>
	[Get("/networks/{networkId}/wireless/rfProfiles")]
	Task<List<WirelessRfProfile>> GetNetworkWirelessRfProfilesAsync(
		string networkId,
		bool? includeTemplateProfiles = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates specified RF profile for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="rfProfileId">The RF profile id</param>
	/// <param name="updateNetworkWirelessRfProfile">Body for updating a specified RF profile</param>
	[Put("/networks/{networkId}/wireless/rfProfiles/{rfProfileId}")]
	Task<WirelessRfProfile> UpdateNetworkWirelessRfProfileAsync(
		string networkId,
		string rfProfileId,
		[Body] WirelessRfProfileCreateUpdateRequest updateNetworkWirelessRfProfile,
		CancellationToken cancellationToken = default
		);
}
