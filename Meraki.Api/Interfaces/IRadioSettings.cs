using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IRadioSettings
	{
		/// <summary>
		/// Creates new RF profile for this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkWirelessRfProfile">Body for creating an RF profile</param>
		[Post("/networks/{networkId}/wireless/rfProfiles")]
		Task<WirelessRfProfileCreationRequest> CreateNetworkWirelessRfProfileAsync(
			[AliasAs("networkId")] string networkId,
			[Body] WirelessRfProfileCreationRequest createNetworkWirelessRfProfile,
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
			[AliasAs("networkId")] string networkId,
			[AliasAs("rfProfileId")] string rfProfileId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the radio settings of a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Get("/devices/{serial}/wireless/radio/settings")]
		Task<RadioGhzSettings> GetNetworkDeviceWirelessRadioSettingsAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a RF profile
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="rfProfileId">The RF profile id</param>
		[Get("/networks/{networkId}/wireless/rfProfiles/{rfProfileId}")]
		Task<WirelessRfProfileCreationRequest> GetNetworkWirelessRfProfileAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("rfProfileId")] string rfProfileId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the non-basic RF profiles for this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="includeTemplateProfiles">If the network is bound to a template, this parameter controls whether or not the non-basic RF profiles defined on the template     should be included in the response alongside the non-basic profiles defined on the bound network. Defaults to false.  (optional)</param>
		[Get("/networks/{networkId}/wireless/rfProfiles")]
		Task<List<WirelessRfProfileCreationRequest>> GetNetworkWirelessRfProfilesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("includeTemplateProfiles")] bool? includeTemplateProfiles = null,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the radio settings of a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="updateNetworkDeviceWirelessRadioSettings">Body for updating radio settings</param>
		[Put("/devices/{serial}/wireless/radio/settings")]
		Task<WirelessRadioSettingsUpdateRequest> UpdateNetworkDeviceWirelessRadioSettingsAsync(
			[AliasAs("serial")] string serial,
			[Body] WirelessRadioSettingsUpdateRequest updateNetworkDeviceWirelessRadioSettings,
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
		Task<WirelessRfProfileCreationRequest> UpdateNetworkWirelessRfProfileAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("rfProfileId")] string rfProfileId,
			[Body] WirelessRfProfileUpdateRequest updateNetworkWirelessRfProfile,
			CancellationToken cancellationToken = default
			);
	}
}
